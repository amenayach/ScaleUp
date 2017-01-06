using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaleUp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];

                ScaleIt(ImageManager.GetAllowedFiles(filePaths));
            }
        }

        private void ScaleIt(string[] files)
        {

            if (files?.Length > 0)
            {

                foreach (var file in files)
                {

                    var bmp =
                        new Bitmap(
                            ImageManager.ResizePicture(
                                    new MemoryStream(File.ReadAllBytes(file))
                                )
                            );

                    picWorkingImage.Image = bmp;
                    var fileInfo = new FileInfo(file);
                    if (fileInfo.DirectoryName != null)
                    {
                        bmp.Save(Path.Combine(fileInfo.DirectoryName, fileInfo.Name + "_Scaled.png"), ImageFormat.Png);
                    }
                }

            }

        }
    }
}
