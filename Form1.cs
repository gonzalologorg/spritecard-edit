using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using TGASharpLib;

namespace MKSCreator
{
    public partial class Form1 : Form
    {
        int frameCount = 0;
        public Form1()
        {
            InitializeComponent();
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);

            string lastImage = Properties.Settings.Default.lastImage;
            if (lastImage != "")
            {
                previewImage.ImageLocation = lastImage;
            }

            string lastPath = Properties.Settings.Default.lastPath;
            if (lastPath != "")
            {
                targetPath.Text = lastPath;
            }

			string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
				Properties.Settings.Default.lastImage = args[1];
				Properties.Settings.Default.Save();

				previewImage.ImageLocation = args[1];
			}
		}

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string file = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            if (file.EndsWith(".png") || file.EndsWith(".jpg") || file.EndsWith(".jpeg"))
            {
                Properties.Settings.Default.lastImage = file;
                Properties.Settings.Default.Save();

                previewImage.ImageLocation = file;
            }
            else
            {
                MessageBox.Show("Please drop a valid image file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Properties.Settings.Default.mksPath;
            if (path == "")
            {
                MessageBox.Show("Please you have to provide mksheet.exe path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Open a save file dialog for a vtf file to save
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "VTF File|*.vtf";
            saveFileDialog1.Title = "Save the VTF file";
            saveFileDialog1.ShowDialog();

            string vtfName = saveFileDialog1.FileName;
            string vmtName = vtfName.Replace(".vtf", ".vmt");
            string fileNameNoExtension = Path.GetFileNameWithoutExtension(vtfName);
            string folder = Path.GetDirectoryName(vtfName);

            generateVMTFile(fileNameNoExtension, vmtName);
            createWorkSpace(folder, vtfName, fileNameNoExtension);
            generateMKS(folder, fileNameNoExtension);
        }

        void createWorkSpace(string folder, string vtf, string fileNoName)
        {
            if (Directory.Exists(folder + "\\" + fileNoName))
                Directory.Delete(folder + "\\" + fileNoName, true);

            Directory.CreateDirectory(folder + "\\" + fileNoName);
            Bitmap image = new Bitmap(previewImage.ImageLocation);
            float cols = Int32.Parse(sizex.Text);
            float rows = Int32.Parse(sizey.Text);
            int colSize = (int)Math.Floor(image.Width / cols);
            int rowSize = (int)Math.Floor(image.Height / rows);

            int frameId = 0;
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    Bitmap newBitmap = new Bitmap(colSize, rowSize);
                    Graphics g = Graphics.FromImage(newBitmap);
                    g.DrawImage(image, new Rectangle(0, 0, colSize, rowSize), new Rectangle(x * colSize, y * rowSize, colSize, rowSize), GraphicsUnit.Pixel);

                    TGA tgaImage = TGA.FromBitmap(newBitmap);
                    tgaImage.Save(folder + "\\" + fileNoName + "\\" + frameId + ".tga");
                    frameId++;
                }
            }

            frameCount = frameId;
        }

        void generateVMTFile(string fileNameNoExtension, string vmt)
        {
            string vmtTemplate = "\"SpriteCard\"\n" +
                "{\n" +
                "\t$basetexture \"" + targetPath.Text + "/" + fileNameNoExtension + "\"\n" +
                "\t$translucent \"1\"\n" +
                "\t$blendframes \"" + (blendBox.Checked ? "1" : "0") + "\"\n" +
                "\t$additive \"" + (additiveCheckbox.Checked ? "1" : "0") + "\"\n}";

            File.WriteAllText(vmt, vmtTemplate);
        }

        string workingDirectory;
        void generateMKS(string folder, string basePath)
        {
            string filePath = folder + "\\" + basePath + "\\";
            string content = "sequence 0";
            if (kindseq.Checked) {
                content += "\nloop\n";

                for (int i = 0; i < frameCount; i++)
                {
                    content += "\nframe " + filePath + i + ".tga" + " 1 ";
                }
            } else
            {
                content += "\nloop";
                for (int i = 0; i < frameCount; i++)
                {
                    content += "\nframe " + filePath + i + ".tga" + " 1\nsequence " + i + "\nloop\n";
                }
            }

            string fileName = basePath + ".mks";
            string mksPath = Properties.Settings.Default.mksPath;
            string vtexPath = mksPath.Replace("mksheet.exe", "vtex.exe");
            string batchFile = "@ECHO ON\n\"" + Properties.Settings.Default.mksPath + "\" \"" + filePath + fileName + "\"\n" +
                "\"" + vtexPath + "\" -dontusegamedir -quiet " + filePath + "\\" + basePath + ".sht\n" +
                "xcopy /y \"" + filePath + "\\" + basePath + ".vtf\"" + " \"" + folder + "\"\n" +
                "rmdir " + filePath + " /s /q\nexit";
            File.WriteAllText(filePath + fileName, content);
            File.WriteAllText(folder + "\\mksheet.bat", batchFile);

            //Run the last created bat file
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = folder + "\\mksheet.bat";
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            workingDirectory = folder + "\\mksheet.bat";

            Process.Start(processStartInfo);
            Task.Run(() => removeFile());
        }

        private async void removeFile()
        {
            await Task.Delay(2000);
            File.Delete(workingDirectory);
        }

        void batch_Exited(object sender, EventArgs e)
        {
            Directory.Delete(workingDirectory, true);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileSelector = new OpenFileDialog();
            fileSelector.Filter = "MKSheet on bin folder|mksheet.exe";
            fileSelector.Title = "Select the mksheet.exe file";
            fileSelector.ShowDialog();

            if (fileSelector.FileName == "")
            {
                return;
            }

            sdkpathLabel.Text = "SDK Path (OK)";
            Properties.Settings.Default.mksPath = fileSelector.FileName;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Properties.Settings.Default.mksPath;
            if (path == "")
            {
                sdkpathLabel.Text = "SDK Path (Not set)";
            }
            else
            {
                sdkpathLabel.Text = "SDK Path (OK)";
            }
            sdkpathLabel.TextAlign = ContentAlignment.MiddleRight;
        }

        private void previewImage_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("Dropped");
        }

        private void previewImage_Paint(object sender, PaintEventArgs e)
        {
            float cols = Int32.Parse(sizex.Text);
            float rows = Int32.Parse(sizey.Text);
            int colSize = (int)Math.Floor(200 / cols);
            int rowSize = (int)Math.Floor(200 / rows);

            using (Pen pen = new Pen(Color.Black, 1))
                e.Graphics.DrawRectangle(pen, 0, 0, 199, 199);

            for (int i = 1; i < cols; i++)
                using (Pen pen = new Pen(Color.HotPink, 1))
                    e.Graphics.DrawLine(pen, new Point(i * colSize, 0), new Point(i * colSize, 200));

            for (int i = 1; i < rows; i++)
                using (Pen pen = new Pen(Color.HotPink, 1))
                    e.Graphics.DrawLine(pen, new Point(0, i * rowSize), new Point(200, i * rowSize));
        }

        private void rowColChange(object sender, EventArgs e)
        {
            TextBox self = (TextBox)sender;
            int result;
            if (Int32.TryParse(self.Text, out result))
            {
                previewImage.Invalidate();
            }
        }

        private void targetPath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.lastPath = targetPath.Text;
            Properties.Settings.Default.Save();
        }
    }
}
