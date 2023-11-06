using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_ffmpeg_app {
    public class FfmpegItem {
        private String inputFilePath;
        private String outputFilePath;
        private String resolution;
        private String outputFormat;
        private String vcodec;
        private String acodec;
        private String videoBitrate;
        private String audioRate;
        private String bitrateTolerance;
        private String audioBitrate;
        private bool deinterlace = false;
        private int totalFrames;
        private int currentFrame;

        /// <summary>
        /// Creates a new FfmpegItem, an object that contains information for ffmpeg to use
        /// </summary>
        public FfmpegItem() { }

        /// <summary>
        /// Creates a new FfmpegItem, an object that contains information for ffmpeg to use
        /// </summary>
        /// <param name="inputFilePath"></param>
        /// <param name="outputFilePath"></param
        public FfmpegItem(String inputFilePath, String outputFilePath) {
            this.inputFilePath = inputFilePath;
            this.outputFilePath = outputFilePath;
        }

        public String CreateFfmpegArgumentString(int cmbTemplateIndex, bool overrideArgumentString = false) {
            String newFilename = Path.GetFileNameWithoutExtension(inputFilePath);
            String argumentString = $"-i \"{inputFilePath}\"";

            if (!overrideArgumentString) {
                if (outputFormat != null) argumentString += $" -f {outputFormat}";
                if (resolution != null) argumentString += $" -s {resolution}";
                if (videoBitrate != null) argumentString += $" -b {videoBitrate}";
                if (bitrateTolerance != null) argumentString += $" -bt {bitrateTolerance}";
                if (vcodec != null) argumentString += $" -vcodec {vcodec}";
                if (deinterlace) argumentString += " -deinterlace";
                if (acodec != null) argumentString += $" -acodec {acodec}";
                if (audioRate != null) argumentString += $" -ar {audioRate}";
                if (audioBitrate != null) argumentString += $" -ab {audioBitrate}";
                if (cmbTemplateIndex == 1) argumentString += $" -ac 2";
            } else {
                argumentString += " [REPLACE ME]";
            }

            argumentString += $" \"{outputFilePath}\\{newFilename}.{this.outputFormat}\"";
            return argumentString;

        }

        public String GetFramecountArgumentString() {
            return $"-i \"{this.inputFilePath}\" -map 0:v:0 -c copy -f null -";
        }

        public int TotalFrames {
            get { return totalFrames; }
            set { totalFrames = value; }
        }

        public int CurrentFrame {
            get { return currentFrame; }
            set { currentFrame = value; }
        }

        public String InputFilePath { 
            get { return inputFilePath; }
            set { inputFilePath = value; }
        }

        public String OutputFilePath { 
            get { return outputFilePath;}
            set { outputFilePath = value; }
        }

        public String Resolution { 
            get { return resolution; }
            set { resolution = value; }
        }

        public String OutputFormat {
            get { return outputFormat; }
            set { outputFormat = value; }
        }

        public String Vcodec {
            get { return vcodec; }
            set { vcodec = value; }
        }

        public String Acodec {
            get { return acodec; }
            set { acodec = value; }
        }

        public String VideoBitrate {
            get { return videoBitrate; }
            set { videoBitrate = value; }
        }

        public String AudioRate {
            get { return audioRate; }
            set { audioRate = value; }
        }

        public String BitrateTolerance {
            get { return bitrateTolerance; }
            set { bitrateTolerance = value; }
        }

        public String AudioBitrate {
            get { return audioBitrate; }
            set { audioBitrate = value; }
        }

        public bool Deinterlace {
            get { return deinterlace; }
            set { deinterlace = value; }
        }
    }
}
