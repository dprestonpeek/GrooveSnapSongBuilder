using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrooveSnapSongBuilder
{
    public partial class GP2MidiConvert : Form
    {
        string gpFile = "";
        string outFile = "";
        string museScoreExe = "";
        ErrorWindow error;
        public GP2MidiConvert()
        {
            InitializeComponent();
            openFileDialog1.FileOk += GPFileSelected;
            saveFileDialog1.FileOk += MidiFileSelected;
            museScoreExe = Path.Combine(Environment.ExpandEnvironmentVariables("%ProgramW6432%"), "MuseScore 3", "bin", "MuseScore3.exe");
            error = new ErrorWindow();
        }

        private void GPFileSelected(object sender, CancelEventArgs e)
        {
            gpFile = openFileDialog1.FileName;
            TabFilePath.Text = gpFile;
        }

        private void MidiFileSelected(object sender, CancelEventArgs e)
        {
            outFile = saveFileDialog1.FileName;
            OutputPath.Text = outFile;
        }

        private void BrowseTabButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void BrowseOutputButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            ConvertGP2Midi();
        }

        private void ConvertGP2Midi()
        {
            if (MuseScoreExists())
            {
                if (File.Exists(gpFile))
                {
                    ExecuteCommand("\"" + museScoreExe + "\"" + " " + "\"" + gpFile + "\"" + " -o " + "\"" + outFile + "\"");
                }
            }
            else
            {
                error.ShowDialog();
            }
        }

        private bool MuseScoreExists()
        {
            if (File.Exists(museScoreExe)) 
            {
                return true;
            }
            return false;
        }

        private async Task<string> ExecuteCommand(string command)
        {
            string commandOutput = "";
            progressBar1.Visible = true;
            await Task.Run(async () =>
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.OutputDataReceived += AdjustProgress;
                cmd.Start();

                cmd.StandardInput.WriteLine(command);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                //Console.WriteLine(cmd.StandardOutput.ReadToEnd());
                commandOutput = cmd.StandardOutput.ReadToEnd();
            });
            progressBar1.Visible = false;
            if (OpenDirCheck.Checked)
            {
                Process.Start("explorer.exe", Path.GetDirectoryName(outFile));
            }
            return commandOutput;
        }

        private void AdjustProgress(object sender, DataReceivedEventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TabFilePath.Text = "";
            OutputPath.Text = "";
            gpFile = "";
            outFile = "";
        }
    }
}
