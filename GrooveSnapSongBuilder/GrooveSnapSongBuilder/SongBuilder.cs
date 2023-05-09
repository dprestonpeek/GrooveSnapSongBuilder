using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;

namespace GrooveSnapSongBuilder
{
    public partial class SongBuilder : Form
    {
        ErrorWindow error;
        string midiFile = "";
        string mp3File = "";
        string mapFile = "";
        string infoFile = "";
        string mp4File = "";

        public SongBuilder()
        {
            InitializeComponent();
            error = new ErrorWindow();
            openFileDialog1.FileOk += AddFile;
            saveFileDialog1.FileOk += BuildGSFile;
            openZipDialog2.FileOk += ZipFileOK;
            saveDrumMapDialog.FileOk += CreateDrumMap;
            saveInfoDialog.FileOk += CreateInfoFile;
        }

        private void AddFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void AddFile(object sender, CancelEventArgs e)
        {
            foreach (string file in openFileDialog1.FileNames)
            {
                if (!FilesList.Items.Contains(file))
                {
                    FilesList.Items.Add(file);
                }
            }
        }

        private void DeleteFiles_Click(object sender, EventArgs e)
        {
            FilesList.Items.Remove(FilesList.SelectedItems);
        }

        private void ClearFiles_Click(object sender, EventArgs e)
        {
            FilesList.Items.Clear();
        }

        private void CheckMaterialsButton_Click(object sender, EventArgs e)
        {
            if (CheckMaterials())
            {
                error.ShowMessage("Success!", "Materials seem to be in the correct configuration");
            }
        }

        private bool CheckMaterials()
        {
            bool midi = false;
            bool mp3 = false;
            bool map = false;
            bool info = false;
            bool mp4 = false;

            string midiF = "";
            string mp3F = "";
            string mapF = "";
            string infoF = "";
            string mp4F = "";

            foreach (string file in FilesList.Items)
            {
                string fileExt = Path.GetExtension(file);
                string fileName = Path.GetFileNameWithoutExtension(file);
                if (fileExt == ".mid" || fileExt == ".midi")
                {
                    if (midi)
                    {
                        midi = false;
                        error.ShowError("There must not be more than 1 midi file.");
                        return false;
                    }
                    midi = true;
                    midiF = file;
                    continue;
                }
                if (fileExt == ".mp3")
                {
                    if (mp3)
                    {
                        mp3 = false;
                        error.ShowError("There must not be more than 1 mp3 file.");
                        return false;
                    }
                    mp3 = true;
                    mp3F = file;
                    continue;
                }
                if (fileExt == ".wav" || fileExt == ".flac")
                {
                    error.ShowError("Please convert your audio file to mp3.");
                    return false;
                }
                if (fileExt == ".txt")
                {
                    if (fileName == "drummap")
                    {
                        if (CanLoadDrumMap(File.ReadAllLines(file))) 
                        {
                            map = true;
                            mapF = file;
                            continue;
                        }
                    }
                    else if (info)
                    {
                        error.ShowError("No drum map file detected. Please ensure the drum map file is named \'drummap.txt\'");
                        return false;
                    }
                    if (fileName == "info")
                    {
                        if (GetInfoStrings(file).Length == 2)
                        {
                            info = true;
                            infoF = file;
                            continue;
                        }
                        else
                        {
                            error.ShowError("Invalid info file. Ensure the info file has the Artist on the first line, Song name on the second, and nothing else");
                            return false;
                        }
                    }
                    else if (map)
                    {
                        error.ShowError("No info file detected. Please ensure the info file is named \'info.txt\'");
                        return false;
                    }
                }
                if (fileExt == ".mp4")
                {
                    mp4 = true;
                    mp4F = file;
                    continue;
                }
            }
            if (midi && mp3 && map && info)
            {
                midiFile = midiF;
                mp3File = mp3F;
                mapFile = mapF;
                infoFile = infoF;
                if (mp4)
                {
                    mp4File = mp4F;
                }
                return true;
            }
            return false;
        }

        public bool CanLoadDrumMap(string[] mapData)
        {
            int[][] drumMap = new int[12][];
            try
            {
                for (int line = 0; line < mapData.Length; line++)
                {
                    //Get the map for each drum
                    string[] split = mapData[line].Split('=');

                    //Get each note and add it to the current map line
                    string[] notes = split[1].Split(',');
                    int[] mapline = new int[notes.Length];
                    for (int note = 0; note < notes.Length; note++)
                    {
                        mapline[note] = int.Parse(notes[note]);
                    }
                    drumMap[line] = mapline;
                }
            }
            catch (Exception ex)
            {
                error.ShowError(ex.Message);
                return false;
            }
            return true;
        }

        private string[] GetInfoStrings(string file)
        {
            return File.ReadAllLines(file);
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            if (CheckMaterials())
            {
                saveFileDialog1.ShowDialog();
            }
        }

        private void BuildGSFile(object sender, CancelEventArgs e)
        {
            string outFile = saveFileDialog1.FileName;
            string[] infoStrings = GetInfoStrings(infoFile);
            string tempPath = Path.Combine(Path.GetDirectoryName(outFile), infoStrings[0], infoStrings[1]);
            string artist = infoStrings[0];
            string song = infoStrings[1];
            if (!Directory.Exists(tempPath))
            {
                Directory.CreateDirectory(tempPath);
            }
            else
            {
                error.ShowError("Unable to create temp location. Please try building .gs file to a different location.");
                return;
            }

            foreach (string file in FilesList.Items)
            {
                File.Copy(file, Path.Combine(tempPath, Path.GetFileName(file)));
            }

            ZipFile.CreateFromDirectory(tempPath, outFile);
            if (File.Exists(outFile))
            {
                if (OpenDir.Checked)
                { 
                    Process.Start("explorer.exe", Path.GetDirectoryName(outFile));
                }
            }
            else
            {
                error.ShowError("An error occurred and your .gs file was not built. I am deeply sorry.");
                return;
            }
        }

        private void UnpackExistingButton_Click(object sender, EventArgs e)
        {
            openZipDialog2.ShowDialog();
        }

        private void ZipFileOK(object sender, CancelEventArgs e)
        {
            string filename = openZipDialog2.FileName;
            string newPath = Path.Combine(Path.GetDirectoryName(filename), Path.GetFileNameWithoutExtension(filename));
            ZipFile.ExtractToDirectory(filename, newPath);
            foreach (string file in Directory.GetFiles(newPath))
            {
                FilesList.Items.Add(file);
            }
        }

        private void GP2MidiButton_Click(object sender, EventArgs e)
        {
            GP2MidiConvert window = new GP2MidiConvert();
            window.Show();
        }

        private void AddDrumMapButton_Click(object sender, EventArgs e)
        {
            saveDrumMapDialog.ShowDialog();
        }

        private void AddInfoFileButton_Click(object sender, EventArgs e)
        {
            saveInfoDialog.ShowDialog();
        }

        private void CreateInfoFile(object sender, CancelEventArgs e)
        {
            string file = saveInfoDialog.FileName;
            if (!File.Exists(file))
            {
                File.WriteAllText(file, Properties.Resources.info);
            }
            string newInfoFile = Path.Combine(Path.GetDirectoryName(file), "info.txt");
            FilesList.Items.Add(newInfoFile);
        }

        private void CreateDrumMap(object sender, CancelEventArgs e)
        {
            string file = saveDrumMapDialog.FileName;
            if (!File.Exists(file))
            {
                File.WriteAllText(file, Properties.Resources.drummap);
            }
            string newInfoFile = Path.Combine(Path.GetDirectoryName(file), "drummap.txt");
            FilesList.Items.Add(newInfoFile);
        }
    }
}
