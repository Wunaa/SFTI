using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Sonic_Frontiers_Tools_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void HedgeArc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will install HedgeArcPack_WIP_Frontiers.7z on the desktop are you sure?", "Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string url = "https://cdn.discordapp.com/attachments/987489054377508924/1039653178494431272/HedgeArcPack_WIP_Frontiers.7z";
                using (var client = new WebClient())
                {
                    using (var dialog = new SaveFileDialog())
                    {
                        dialog.Filter = "7Zip Files (*.7z)|*.7z";
                        dialog.FileName = "HedgeArcPack_WIP_Frontiers.7z";
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            string fileName = dialog.FileName;
                            client.DownloadFile(url, fileName);
                        }
                    }
                }
            }
        }

        private void HedgeEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will install HedgeEdit.zip are you sure?", "Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string url = "https://cdn.discordapp.com/attachments/946312699497840700/1070704945885610104/HedgeEdit.zip";
                using (var client = new WebClient())
                {
                    using (var dialog = new SaveFileDialog())
                    {
                        dialog.Filter = "Zip Files (*.zip)|*.zip";
                        dialog.FileName = "HedgeEdit.zip";
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            string fileName = dialog.FileName;
                            client.DownloadFile(url, fileName);
                        }
                    }
                }
            }
        }

        private void HedgeNeedle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will install HedgeNeedle.7z are you sure?", "Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string url = "https://cdn.discordapp.com/attachments/464963211410669579/1039655306378100816/HedgeNeedle.7z";
                using (var client = new WebClient())
                {
                    using (var dialog = new SaveFileDialog())
                    {
                        dialog.Filter = "7z Files (*.7z)|*.7z";
                        dialog.FileName = "HedgeNeedle.7z";
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            string fileName = dialog.FileName;
                            client.DownloadFile(url, fileName);
                        }
                    }
                }
            }
        }

        private void HE2_Model_Im_Blender_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will take you to the github to download the py files", "Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string url = "https://github.com/Turk645/Hedgehog-Engine-2-Mesh-Blender-Importer";
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }

        private void FrontiersAnimDecompress_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will install FrontiersAnimImport.rar are you sure?", "Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string url = "https://github.com/WistfulHopes/FrontiersAnimDecompress/releases/download/1.02/FrontiersAnimImport.rar";
                using (var client = new WebClient())
                {
                    using (var dialog = new SaveFileDialog())
                    {
                        dialog.Filter = "Rar Files (*.rar)|*.rar";
                        dialog.FileName = "FrontiersAnimImport.rar";
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            string fileName = dialog.FileName;
                            client.DownloadFile(url, fileName);
                        }
                    }
                }
            }
        }

        private void SkythTools_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will install master.zip and might take up to 10-30 seconds are you sure?", "Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string url = "https://github.com/blueskythlikesclouds/SkythTools/archive/refs/heads/master.zip";
                using (var client = new WebClient())
                {
                    using (var dialog = new SaveFileDialog())
                    {
                        dialog.Filter = "Zip Files (*.zip)|*.zip";
                        dialog.FileName = "master.zip";
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            string fileName = dialog.FileName;
                            // Attach the event handler to the DownloadProgressChanged event
                            client.DownloadProgressChanged += (sender, e) =>
                            {
                                // Update the progress bar with the percentage downloaded
                                progressBar1.Value = e.ProgressPercentage;
                            };

                            // Download the file and save it to the selected file location
                            client.DownloadFile(url, fileName);
                        }
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will take you to the 010 website to download it", "Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string url = "https://www.sweetscape.com/010editor/";
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will exit the Installer are you sure?", "Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to check if theres an update (It takes you to the github, idk if theres an update yet)", "Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes) ;
            {
                string url = "https://github.com/Wunaa/MidManger/releases";
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void SFCemtColorEditor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will install SF-CemtColorEditor-main.zip are you sure?", "Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string url = "https://cdn.discordapp.com/attachments/987489054377508924/1043340333032935506/SF-CemtColorEditor-main.zip";
                using (var client = new WebClient())
                {
                    using (var dialog = new SaveFileDialog())
                    {
                        dialog.Filter = "Zip Files (*.zip)|*.zip";
                        dialog.FileName = "SF-CemtColorEditor-main.zip";
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            string fileName = dialog.FileName;
                            // Attach the event handler to the DownloadProgressChanged event
                            client.DownloadProgressChanged += (sender, e) =>
                            {
                                // Update the progress bar with the percentage downloaded
                                progressBar1.Value = e.ProgressPercentage;
                            };

                            // Download the file and save it to the selected file location
                            client.DownloadFile(url, fileName);
                        }
                    }
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Download_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Download, 0, Download.Height);
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("This will install EVERYTHING in this application are you sure?", "Installer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes) ;
            {
                string url = "https://cdn.discordapp.com/attachments/1065659373617172592/1095529192843653160/FrontiersPack.zip";
                using (var client = new WebClient())
                {
                    using (var dialog = new SaveFileDialog())
                    {
                        dialog.Filter = "Zip Files (*.zip)|*.zip";
                        dialog.FileName = "FrontiersPack.zip";
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            string fileName = dialog.FileName;
                            // Attach the event handler to the DownloadProgressChanged event
                            client.DownloadProgressChanged += (sender, e) =>
                            {
                                // Update the progress bar with the percentage downloaded
                                progressBar1.Value = e.ProgressPercentage;
                            };

                            // Download the file and save it to the selected file location
                            client.DownloadFile(url, fileName);
                        }
                    }
                }
            }
        }
    }
}
    