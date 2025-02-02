using ImageMagick;
using ImageMagick.Formats;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HEIC2PNG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseFolder_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.CheckFileExists = false;
                openFileDialog.CheckPathExists = true;
                openFileDialog.FileName = "Select folder";
                openFileDialog.ValidateNames = false;
                openFileDialog.Filter = "Folders|*.none";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = Path.GetDirectoryName(openFileDialog.FileName);
                    if (Directory.Exists(folderPath))
                    {
                        FolderPath.Text = folderPath;
                    }
                    else
                    {
                        FolderPath.Text = "";
                    }
                    PopulateFileList();
                }
            }
        }

        private void PopulateFileList()
        {
            string folderPath = FolderPath.Text;

            FileList.Items.Clear();
            FileList.Enabled = false;
            
            if (Directory.Exists(folderPath))
            {
                string[] heicFiles = Directory.GetFiles(folderPath, "*.HEIC");
                string[] pngFiles = Directory.GetFiles(folderPath, "*.PNG");

                var pngFileNames = new HashSet<string>(pngFiles.Select(f => Path.GetFileNameWithoutExtension(f)));
                heicFiles = heicFiles.Where(f => !pngFileNames.Contains(Path.GetFileNameWithoutExtension(f))).ToArray();

                foreach (var file in heicFiles)
                {
                    FileList.Items.Add(file);
                }
            }

            ConvertButton.Enabled = (FileList.Items.Count > 0);
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            ConvertButton.Enabled = false;
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = FileList.Items.Count;
            ProgressBar.Value = 0;

            foreach (ListViewItem item in FileList.Items)
            {
                string heicFilePath = item.Text;
                string pngFilePath = Path.ChangeExtension(heicFilePath, ".png");

                if (!File.Exists(pngFilePath))
                {
                    var settings = new MagickReadSettings();
                    settings.Format = MagickFormat.Heic;

                    using (MagickImage image = new MagickImage(heicFilePath, settings))
                    {
                        image.Write(pngFilePath);
                    }

                    if (File.Exists(pngFilePath))
                    {
                        // Delete the original HEIC file
                        File.Delete(heicFilePath);
                    }
                }

                ProgressBar.Value += 1;
            }

            MessageBox.Show("Conversion completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FileList.Items.Clear();
            ProgressBar.Value = 0;
        }
    }
}
