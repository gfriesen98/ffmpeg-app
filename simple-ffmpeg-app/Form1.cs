using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_ffmpeg_app {
    public partial class Form1 : Form {

        public FfmpegItem ffmpegItem = new FfmpegItem();

        public Form1() {
            InitializeComponent();
        }


        private void btnInputFile_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                ffmpegItem.InputFilePath = openFileDialog1.FileName;
                txtInputFile.Text = openFileDialog1.FileName;
                ffmpegItem.InputFilePath = openFileDialog1.FileName;
            }
        }

        private void btnDestinationFolder_Click(object sender, EventArgs e) {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                ffmpegItem.OutputFilePath = folderBrowserDialog1.SelectedPath;
                txtDestinationFolder.Text = folderBrowserDialog1.SelectedPath;
                ffmpegItem.OutputFilePath = folderBrowserDialog1.SelectedPath;
            }
        }
        private void cmbTemplate_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cmbTemplate.SelectedIndex) {
                case 0:
                    DefaultAllAttributeTextBoxes();
                    txtOutputFormat.Text = "mp4";
                    ffmpegItem.OutputFormat = "mp4";
                    break;

                case 1:
                    SetDSVideoDefaults();
                    break;
                case 2: // not finished
                    DefaultAllAttributeTextBoxes();
                    break;
                case 3: // not finished
                    DefaultAllAttributeTextBoxes();
                    break;
                default:
                    DefaultAllAttributeTextBoxes();
                    break;
            }

            String argumentString = ffmpegItem.CreateFfmpegArgumentString(cmbTemplate.SelectedIndex);
            txtOverrideArgumentString.Text = argumentString;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtOutputFormat_TextChanged(object sender, EventArgs e) {
            ffmpegItem.OutputFormat = txtOutputFormat.Text;
        }

        private async void btnConvert_Click(object sender, EventArgs e) {
            ProcessStartInfo ffmpegConvertInfo = new ProcessStartInfo {
                FileName = "ffmpeg",
                Arguments = ffmpegItem.CreateFfmpegArgumentString(cmbTemplate.SelectedIndex),
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            ProcessStartInfo ffmpegCountFramesInfo = new ProcessStartInfo {
                FileName = "ffmpeg",
                Arguments = $"-i \"{ffmpegItem.InputFilePath}\" -map 0:v:0 -c copy -f null -",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            // get selected video frame count with ffmpeg
            Process countFramesProc = new Process {
                StartInfo = ffmpegCountFramesInfo
            };

            countFramesProc.OutputDataReceived += (senderProcess, args) => {
                if (!string.IsNullOrWhiteSpace(args.Data)) {
                    UpdateTextElement(args.Data, true);
                }
            };

            countFramesProc.ErrorDataReceived += (senderProcess, args) => {
                if (!string.IsNullOrWhiteSpace(args.Data)) {
                    UpdateTextElement(args.Data, true);
                }
            };

            countFramesProc.Start();
            countFramesProc.BeginOutputReadLine();
            countFramesProc.BeginErrorReadLine();
            await Task.Run(() => {
                countFramesProc.WaitForExit();
            });

            countFramesProc.Close();
            textBox1.AppendText($"[my code] ffmpegItem.TotalFrames = {ffmpegItem.TotalFrames}");

            // start conversion. parse current frame from ffmpeg output
            Process convertProc = new Process {
                StartInfo = ffmpegConvertInfo
            };

            convertProc.OutputDataReceived += (senderProcess, args) => {
                if (!string.IsNullOrWhiteSpace(args.Data)) {
                    UpdateTextElement(args.Data, false);
                    UpdateLabelElement(args.Data);
                    UpdateProgressBarElement(args.Data);
                }
            };

            convertProc.ErrorDataReceived += (senderProcess, args) => {
                if (!string.IsNullOrWhiteSpace(args.Data)) {
                    UpdateTextElement(args.Data, false);
                    UpdateLabelElement(args.Data);
                    UpdateProgressBarElement(args.Data);
                }
            };

            // set up progress bar
            lblCurrentFrame.Visible = true;
            lblFrame.Visible = true;
            progressBar.Minimum = 1;
            progressBar.Maximum = ffmpegItem.TotalFrames;
            progressBar.Value = 1;

            convertProc.Start();
            convertProc.BeginOutputReadLine();
            convertProc.BeginErrorReadLine();
            await Task.Run(() => {
                convertProc.WaitForExit();
            });

            convertProc.Close();
            textBox1.AppendText($"[my code] DONE");
            lblCurrentFrame.Text += " - Done!";
        }

        private String GetFfmpegFrameNumber(string text) {
            return Regex.Replace(text.Split('=')[1].Trim(), @"fps", "").Trim();
        }

        /// <summary>
        /// Update the text element with live stdout from ffmpeg
        /// </summary>
        /// <param name="text">stdout</param>
        /// <param name="isFramecount">true if checking for frame count and not conversions</param>
        private void UpdateTextElement(string text, bool isFramecount = false) { 
            if (textBox1.InvokeRequired) {
                textBox1.Invoke(new Action(() => UpdateTextElement(text, isFramecount)));
            } else {
                if (text.Contains("frame=")) {
                    String output = GetFfmpegFrameNumber(text);

                    if (isFramecount) {
                        // store total frame count in the ffmpegItem object for later
                        //ffmpegItem.TotalFrames = Int32.Parse(Regex.Replace(text.Split('=')[1].Trim(), @"fps", "").Trim());
                        ffmpegItem.TotalFrames = Int32.Parse(output);
                        //textBox1.Text += $"[ffmpeg std]{Regex.Replace(text.Split('=')[1].Trim(), @"fps", "")}\n";
                        textBox1.AppendText($"[ffmpeg] Frame {output}");
                    } else {
                        //textBox1.Text += $"[ffmpeg std]{Regex.Replace(text.Split('=')[1].Trim(), @"fps", "")}\n";
                        textBox1.AppendText($"[ffmpeg] {output}");
                    }
                }
            }
        }

        /// <summary>
        /// Update the progress label element with live stdout from ffmpeg. Used after checking for total frame count
        /// </summary>
        /// <param name="text"></param>
        private void UpdateLabelElement(string text) {
            if (lblCurrentFrame.InvokeRequired) { 
                lblCurrentFrame.Invoke(new Action(() => UpdateLabelElement(text)));
            } else {
                if (text.Contains("frame=")) {
                    //lblCurrentFrame.Text = $"{Regex.Replace(text.Split('=')[1].Trim(), @"fps", "").Trim()}/{ffmpegItem.TotalFrames}";
                    lblCurrentFrame.Text = $"{GetFfmpegFrameNumber(text)}/{ffmpegItem.TotalFrames}";
                }
            }
        }

        /// <summary>
        /// Update the progress bar based on how many frames are completed by ffmpeg. Used after checking for total frame count
        /// </summary>
        /// <param name="text"></param>
        private void UpdateProgressBarElement(string text) {
            if (progressBar.InvokeRequired) {
                progressBar.Invoke(new Action(() => UpdateProgressBarElement(text)));
            } else {
                if (text.Contains("frame=")) {
                    //int value = Int32.Parse(Regex.Replace(text.Split('=')[1].Trim(), @"fps", "").Trim());
                    progressBar.Value = Int32.Parse(GetFfmpegFrameNumber(text));
                }
            }
        }

        private void DefaultAllAttributeTextBoxes() {
            txtOutputFormat.Text = "default";
            txtOutputFormat.Enabled = true;
            txtResolution.Text = "default";
            txtResolution.Enabled = true;
            txtVcodec.Text = "default";
            txtVcodec.Enabled = true;
            txtAcodec.Text = "default";
            txtAcodec.Enabled = true;
            txtVideoBitrate.Text = "default";
            txtVideoBitrate.Enabled = true;
            txtAudioBitrate.Text = "default";
            txtAudioBitrate.Enabled = true;
            txtAudioRate.Text = "default";
            txtAudioRate.Enabled = true;
            txtBitrateTolerance.Text = "default";
            txtBitrateTolerance.Enabled = true;
            chkDeinterlace.Checked = false;
            chkDeinterlace.Enabled = true;
        }

        private void SetDSVideoDefaults() {
            ffmpegItem.OutputFormat = "avi";
            txtOutputFormat.Text = "avi";
            txtOutputFormat.Enabled = false;

            ffmpegItem.Resolution = "256x144";
            txtResolution.Text = "256x144";
            txtResolution.Enabled = false;

            ffmpegItem.Vcodec = "libxvid";
            txtVcodec.Text = "libxvid";
            txtVcodec.Enabled = false;

            ffmpegItem.Acodec = "libmp3lame";
            txtAcodec.Text = "libmp3lame";
            txtAcodec.Enabled = false;

            ffmpegItem.VideoBitrate = "512k";
            txtVideoBitrate.Text = "512k";
            txtVideoBitrate.Enabled = false;

            ffmpegItem.AudioBitrate = "96k";
            txtAudioBitrate.Text = "96k";
            txtAudioBitrate.Enabled = false;

            ffmpegItem.AudioRate = "32000";
            txtAudioRate.Text = "32000";
            txtAudioRate.Enabled = false;

            ffmpegItem.BitrateTolerance = "256k";
            txtBitrateTolerance.Text = "256k";
            txtBitrateTolerance.Enabled = false;

            ffmpegItem.Deinterlace = true;
            chkDeinterlace.Checked = true;
            chkDeinterlace.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            textBox1.Visible = enableOutput.Checked;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e) {
            txtOverrideArgumentString.ReadOnly = !overrideArgumentToggle.Checked;
            txtOverrideArgumentString.Text = ffmpegItem.CreateFfmpegArgumentString(cmbTemplate.SelectedIndex);
        }

        private void txtInputFile_TextChanged(object sender, EventArgs e) {
            if (txtDestinationFolder.Text == "No destination selected!" || txtInputFile.Text == "No file selected!") {
                btnConvert.Enabled = false;
            } else {
                btnConvert.Enabled = true;
            }
        }

        private void txtDestinationFolder_TextChanged(object sender, EventArgs e) {
            if (txtDestinationFolder.Text == "No destination selected!" || txtInputFile.Text == "No file selected!") {
                btnConvert.Enabled = false;
            } else {
                btnConvert.Enabled = true;
            }
        }
    }
}
