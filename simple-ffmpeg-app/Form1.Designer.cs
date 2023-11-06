namespace simple_ffmpeg_app
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxInputFile = new System.Windows.Forms.GroupBox();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.lblSelectedInputFile = new System.Windows.Forms.Label();
            this.btnInputFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxOutputFile = new System.Windows.Forms.GroupBox();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDestinationFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.overrideArgumentToggle = new System.Windows.Forms.CheckBox();
            this.txtOverrideArgumentString = new System.Windows.Forms.TextBox();
            this.chkDeinterlace = new System.Windows.Forms.CheckBox();
            this.txtBitrateTolerance = new System.Windows.Forms.TextBox();
            this.lblBitrateTolerance = new System.Windows.Forms.Label();
            this.txtVideoBitrate = new System.Windows.Forms.TextBox();
            this.lblVideoBitrate = new System.Windows.Forms.Label();
            this.txtAudioBitrate = new System.Windows.Forms.TextBox();
            this.lblAudioBitrate = new System.Windows.Forms.Label();
            this.txtAudioRate = new System.Windows.Forms.TextBox();
            this.lblAudioRate = new System.Windows.Forms.Label();
            this.txtAcodec = new System.Windows.Forms.TextBox();
            this.lblAcodec = new System.Windows.Forms.Label();
            this.txtVcodec = new System.Windows.Forms.TextBox();
            this.lblVcodec = new System.Windows.Forms.Label();
            this.txtResolution = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutputFormat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTemplate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblFrame = new System.Windows.Forms.Label();
            this.lblCurrentFrame = new System.Windows.Forms.Label();
            this.enableOutput = new System.Windows.Forms.CheckBox();
            this.groupBoxInputFile.SuspendLayout();
            this.groupBoxOutputFile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInputFile
            // 
            this.groupBoxInputFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBoxInputFile.Controls.Add(this.txtInputFile);
            this.groupBoxInputFile.Controls.Add(this.lblSelectedInputFile);
            this.groupBoxInputFile.Controls.Add(this.btnInputFile);
            this.groupBoxInputFile.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInputFile.Name = "groupBoxInputFile";
            this.groupBoxInputFile.Size = new System.Drawing.Size(324, 100);
            this.groupBoxInputFile.TabIndex = 0;
            this.groupBoxInputFile.TabStop = false;
            this.groupBoxInputFile.Text = "Input File";
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(12, 66);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.ReadOnly = true;
            this.txtInputFile.Size = new System.Drawing.Size(306, 20);
            this.txtInputFile.TabIndex = 2;
            this.txtInputFile.Text = "No file selected!";
            this.txtInputFile.TextChanged += new System.EventHandler(this.txtInputFile_TextChanged);
            // 
            // lblSelectedInputFile
            // 
            this.lblSelectedInputFile.AutoSize = true;
            this.lblSelectedInputFile.Location = new System.Drawing.Point(9, 49);
            this.lblSelectedInputFile.Name = "lblSelectedInputFile";
            this.lblSelectedInputFile.Size = new System.Drawing.Size(71, 13);
            this.lblSelectedInputFile.TabIndex = 1;
            this.lblSelectedInputFile.Text = "Selected File:";
            // 
            // btnInputFile
            // 
            this.btnInputFile.Location = new System.Drawing.Point(12, 19);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(165, 23);
            this.btnInputFile.TabIndex = 0;
            this.btnInputFile.Text = "Select Input File";
            this.btnInputFile.UseVisualStyleBackColor = true;
            this.btnInputFile.Click += new System.EventHandler(this.btnInputFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 604);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(162, 59);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // groupBoxOutputFile
            // 
            this.groupBoxOutputFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBoxOutputFile.Controls.Add(this.txtDestinationFolder);
            this.groupBoxOutputFile.Controls.Add(this.label1);
            this.groupBoxOutputFile.Controls.Add(this.btnDestinationFolder);
            this.groupBoxOutputFile.Location = new System.Drawing.Point(12, 118);
            this.groupBoxOutputFile.Name = "groupBoxOutputFile";
            this.groupBoxOutputFile.Size = new System.Drawing.Size(324, 100);
            this.groupBoxOutputFile.TabIndex = 1;
            this.groupBoxOutputFile.TabStop = false;
            this.groupBoxOutputFile.Text = "Output File";
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Location = new System.Drawing.Point(12, 65);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.ReadOnly = true;
            this.txtDestinationFolder.Size = new System.Drawing.Size(306, 20);
            this.txtDestinationFolder.TabIndex = 2;
            this.txtDestinationFolder.Text = "No destination selected!";
            this.txtDestinationFolder.TextChanged += new System.EventHandler(this.txtDestinationFolder_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name:";
            // 
            // btnDestinationFolder
            // 
            this.btnDestinationFolder.Location = new System.Drawing.Point(12, 19);
            this.btnDestinationFolder.Name = "btnDestinationFolder";
            this.btnDestinationFolder.Size = new System.Drawing.Size(165, 23);
            this.btnDestinationFolder.TabIndex = 0;
            this.btnDestinationFolder.Text = "Select Destination Folder";
            this.btnDestinationFolder.UseVisualStyleBackColor = true;
            this.btnDestinationFolder.Click += new System.EventHandler(this.btnDestinationFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.overrideArgumentToggle);
            this.groupBox1.Controls.Add(this.txtOverrideArgumentString);
            this.groupBox1.Controls.Add(this.chkDeinterlace);
            this.groupBox1.Controls.Add(this.txtBitrateTolerance);
            this.groupBox1.Controls.Add(this.lblBitrateTolerance);
            this.groupBox1.Controls.Add(this.txtVideoBitrate);
            this.groupBox1.Controls.Add(this.lblVideoBitrate);
            this.groupBox1.Controls.Add(this.txtAudioBitrate);
            this.groupBox1.Controls.Add(this.lblAudioBitrate);
            this.groupBox1.Controls.Add(this.txtAudioRate);
            this.groupBox1.Controls.Add(this.lblAudioRate);
            this.groupBox1.Controls.Add(this.txtAcodec);
            this.groupBox1.Controls.Add(this.lblAcodec);
            this.groupBox1.Controls.Add(this.txtVcodec);
            this.groupBox1.Controls.Add(this.lblVcodec);
            this.groupBox1.Controls.Add(this.txtResolution);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtOutputFormat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTemplate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 324);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ffmpeg Attributes";
            // 
            // overrideArgumentToggle
            // 
            this.overrideArgumentToggle.AutoSize = true;
            this.overrideArgumentToggle.Location = new System.Drawing.Point(15, 65);
            this.overrideArgumentToggle.Name = "overrideArgumentToggle";
            this.overrideArgumentToggle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.overrideArgumentToggle.Size = new System.Drawing.Size(141, 17);
            this.overrideArgumentToggle.TabIndex = 20;
            this.overrideArgumentToggle.Text = "Override argument string";
            this.overrideArgumentToggle.UseVisualStyleBackColor = true;
            this.overrideArgumentToggle.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // txtOverrideArgumentString
            // 
            this.txtOverrideArgumentString.Location = new System.Drawing.Point(15, 88);
            this.txtOverrideArgumentString.Name = "txtOverrideArgumentString";
            this.txtOverrideArgumentString.ReadOnly = true;
            this.txtOverrideArgumentString.Size = new System.Drawing.Size(303, 20);
            this.txtOverrideArgumentString.TabIndex = 19;
            // 
            // chkDeinterlace
            // 
            this.chkDeinterlace.AutoSize = true;
            this.chkDeinterlace.Location = new System.Drawing.Point(11, 298);
            this.chkDeinterlace.Name = "chkDeinterlace";
            this.chkDeinterlace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDeinterlace.Size = new System.Drawing.Size(78, 17);
            this.chkDeinterlace.TabIndex = 18;
            this.chkDeinterlace.Text = "deinterlace";
            this.chkDeinterlace.UseVisualStyleBackColor = true;
            // 
            // txtBitrateTolerance
            // 
            this.txtBitrateTolerance.Location = new System.Drawing.Point(15, 272);
            this.txtBitrateTolerance.Name = "txtBitrateTolerance";
            this.txtBitrateTolerance.Size = new System.Drawing.Size(100, 20);
            this.txtBitrateTolerance.TabIndex = 17;
            this.txtBitrateTolerance.Text = "default";
            // 
            // lblBitrateTolerance
            // 
            this.lblBitrateTolerance.AutoSize = true;
            this.lblBitrateTolerance.Location = new System.Drawing.Point(12, 256);
            this.lblBitrateTolerance.Name = "lblBitrateTolerance";
            this.lblBitrateTolerance.Size = new System.Drawing.Size(83, 13);
            this.lblBitrateTolerance.TabIndex = 16;
            this.lblBitrateTolerance.Text = "bitrate tolerance";
            // 
            // txtVideoBitrate
            // 
            this.txtVideoBitrate.Location = new System.Drawing.Point(15, 227);
            this.txtVideoBitrate.Name = "txtVideoBitrate";
            this.txtVideoBitrate.Size = new System.Drawing.Size(100, 20);
            this.txtVideoBitrate.TabIndex = 15;
            this.txtVideoBitrate.Text = "default";
            // 
            // lblVideoBitrate
            // 
            this.lblVideoBitrate.AutoSize = true;
            this.lblVideoBitrate.Location = new System.Drawing.Point(12, 212);
            this.lblVideoBitrate.Name = "lblVideoBitrate";
            this.lblVideoBitrate.Size = new System.Drawing.Size(65, 13);
            this.lblVideoBitrate.TabIndex = 14;
            this.lblVideoBitrate.Text = "video bitrate";
            // 
            // txtAudioBitrate
            // 
            this.txtAudioBitrate.Location = new System.Drawing.Point(209, 272);
            this.txtAudioBitrate.Name = "txtAudioBitrate";
            this.txtAudioBitrate.Size = new System.Drawing.Size(100, 20);
            this.txtAudioBitrate.TabIndex = 13;
            this.txtAudioBitrate.Text = "default";
            // 
            // lblAudioBitrate
            // 
            this.lblAudioBitrate.AutoSize = true;
            this.lblAudioBitrate.Location = new System.Drawing.Point(206, 256);
            this.lblAudioBitrate.Name = "lblAudioBitrate";
            this.lblAudioBitrate.Size = new System.Drawing.Size(65, 13);
            this.lblAudioBitrate.TabIndex = 12;
            this.lblAudioBitrate.Text = "audio bitrate";
            // 
            // txtAudioRate
            // 
            this.txtAudioRate.Location = new System.Drawing.Point(209, 228);
            this.txtAudioRate.Name = "txtAudioRate";
            this.txtAudioRate.Size = new System.Drawing.Size(100, 20);
            this.txtAudioRate.TabIndex = 11;
            this.txtAudioRate.Text = "default";
            // 
            // lblAudioRate
            // 
            this.lblAudioRate.AutoSize = true;
            this.lblAudioRate.Location = new System.Drawing.Point(206, 212);
            this.lblAudioRate.Name = "lblAudioRate";
            this.lblAudioRate.Size = new System.Drawing.Size(54, 13);
            this.lblAudioRate.TabIndex = 10;
            this.lblAudioRate.Text = "audio rate";
            // 
            // txtAcodec
            // 
            this.txtAcodec.Location = new System.Drawing.Point(209, 186);
            this.txtAcodec.Name = "txtAcodec";
            this.txtAcodec.Size = new System.Drawing.Size(100, 20);
            this.txtAcodec.TabIndex = 9;
            this.txtAcodec.Text = "default";
            // 
            // lblAcodec
            // 
            this.lblAcodec.AutoSize = true;
            this.lblAcodec.Location = new System.Drawing.Point(206, 170);
            this.lblAcodec.Name = "lblAcodec";
            this.lblAcodec.Size = new System.Drawing.Size(43, 13);
            this.lblAcodec.TabIndex = 8;
            this.lblAcodec.Text = "acodec";
            // 
            // txtVcodec
            // 
            this.txtVcodec.Location = new System.Drawing.Point(15, 186);
            this.txtVcodec.Name = "txtVcodec";
            this.txtVcodec.Size = new System.Drawing.Size(100, 20);
            this.txtVcodec.TabIndex = 7;
            this.txtVcodec.Text = "default";
            // 
            // lblVcodec
            // 
            this.lblVcodec.AutoSize = true;
            this.lblVcodec.Location = new System.Drawing.Point(12, 170);
            this.lblVcodec.Name = "lblVcodec";
            this.lblVcodec.Size = new System.Drawing.Size(43, 13);
            this.lblVcodec.TabIndex = 6;
            this.lblVcodec.Text = "vcodec";
            // 
            // txtResolution
            // 
            this.txtResolution.Location = new System.Drawing.Point(209, 141);
            this.txtResolution.Name = "txtResolution";
            this.txtResolution.Size = new System.Drawing.Size(100, 20);
            this.txtResolution.TabIndex = 5;
            this.txtResolution.Text = "default";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Resolution";
            // 
            // txtOutputFormat
            // 
            this.txtOutputFormat.Location = new System.Drawing.Point(15, 142);
            this.txtOutputFormat.Name = "txtOutputFormat";
            this.txtOutputFormat.Size = new System.Drawing.Size(100, 20);
            this.txtOutputFormat.TabIndex = 3;
            this.txtOutputFormat.Text = "mp4";
            this.txtOutputFormat.TextChanged += new System.EventHandler(this.txtOutputFormat_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output Format";
            // 
            // cmbTemplate
            // 
            this.cmbTemplate.FormattingEnabled = true;
            this.cmbTemplate.Items.AddRange(new object[] {
            "None",
            "DS (DSTwo Video Player)",
            "PSP",
            "PSVita"});
            this.cmbTemplate.Location = new System.Drawing.Point(15, 37);
            this.cmbTemplate.Name = "cmbTemplate";
            this.cmbTemplate.Size = new System.Drawing.Size(303, 21);
            this.cmbTemplate.TabIndex = 1;
            this.cmbTemplate.SelectedIndexChanged += new System.EventHandler(this.cmbTemplate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Template";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Location = new System.Drawing.Point(261, 640);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 640);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 556);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(324, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            this.progressBar.UseWaitCursor = true;
            // 
            // lblFrame
            // 
            this.lblFrame.AutoSize = true;
            this.lblFrame.Location = new System.Drawing.Point(12, 582);
            this.lblFrame.Name = "lblFrame";
            this.lblFrame.Size = new System.Drawing.Size(39, 13);
            this.lblFrame.TabIndex = 7;
            this.lblFrame.Text = "Frame:";
            this.lblFrame.Visible = false;
            // 
            // lblCurrentFrame
            // 
            this.lblCurrentFrame.AutoSize = true;
            this.lblCurrentFrame.Location = new System.Drawing.Point(50, 582);
            this.lblCurrentFrame.Name = "lblCurrentFrame";
            this.lblCurrentFrame.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentFrame.TabIndex = 8;
            this.lblCurrentFrame.Text = "0";
            this.lblCurrentFrame.Visible = false;
            // 
            // enableOutput
            // 
            this.enableOutput.AutoSize = true;
            this.enableOutput.Location = new System.Drawing.Point(242, 581);
            this.enableOutput.Name = "enableOutput";
            this.enableOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enableOutput.Size = new System.Drawing.Size(94, 17);
            this.enableOutput.TabIndex = 9;
            this.enableOutput.Text = "Enable Output";
            this.enableOutput.UseVisualStyleBackColor = true;
            this.enableOutput.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(348, 671);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enableOutput);
            this.Controls.Add(this.lblCurrentFrame);
            this.Controls.Add(this.lblFrame);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxOutputFile);
            this.Controls.Add(this.groupBoxInputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "shitty ffmpeg gui";
            this.groupBoxInputFile.ResumeLayout(false);
            this.groupBoxInputFile.PerformLayout();
            this.groupBoxOutputFile.ResumeLayout(false);
            this.groupBoxOutputFile.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInputFile;
        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.GroupBox groupBoxOutputFile;
        private System.Windows.Forms.Button btnDestinationFolder;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Label lblSelectedInputFile;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTemplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtAcodec;
        private System.Windows.Forms.Label lblAcodec;
        private System.Windows.Forms.TextBox txtVcodec;
        private System.Windows.Forms.Label lblVcodec;
        private System.Windows.Forms.TextBox txtResolution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutputFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkDeinterlace;
        private System.Windows.Forms.TextBox txtBitrateTolerance;
        private System.Windows.Forms.Label lblBitrateTolerance;
        private System.Windows.Forms.TextBox txtVideoBitrate;
        private System.Windows.Forms.Label lblVideoBitrate;
        private System.Windows.Forms.TextBox txtAudioBitrate;
        private System.Windows.Forms.Label lblAudioBitrate;
        private System.Windows.Forms.TextBox txtAudioRate;
        private System.Windows.Forms.Label lblAudioRate;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFrame;
        private System.Windows.Forms.Label lblCurrentFrame;
        private System.Windows.Forms.CheckBox enableOutput;
        private System.Windows.Forms.CheckBox overrideArgumentToggle;
        private System.Windows.Forms.TextBox txtOverrideArgumentString;
    }
}

