
using System.Windows.Forms;

namespace PictureViewNew
{
    public partial class FormMain : Form
    {
        private string[]? imageFiles;
        private int currentImageIndex = -1;
        private bool isFullScreen = false;
        private string currentImagePath = string.Empty;

        public FormMain()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // pictureBox1.Load(openFileDialog1.FileName);

                currentImagePath = openFileDialog1.FileName;

                using (FileStream fs = new FileStream(currentImagePath, FileMode.Open))
                {
                    pictureBox1.Image = Image.FromStream(fs);
                }
                
                ////allows overriding the image in case of save
                //Image image = new Bitmap(pictureBox1.Image);
                //pictureBox1.Image = image;

                this.Text = $"Picture Viewer - {Path.GetFileName(openFileDialog1.FileName)}";
                LoadImageFolder(Path.GetDirectoryName(openFileDialog1.FileName));                  
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (imageFiles == null || imageFiles.Length == 0)
            {
                MessageBox.Show("No images loaded. Please open a folder with images first.");
                return;
            }

            // Increment the index and wrap around if necessary
            currentImageIndex = (currentImageIndex + 1) % imageFiles.Length;

            // Load the next image
            LoadImage(imageFiles[currentImageIndex]);
        }
        private void LoadImage(string filePath)
        {
            try
            {
                // Dispose of any previous image if it's already loaded
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }

                pictureBox1.Image = Image.FromFile(filePath);
                currentImagePath = filePath;
                this.Text = $"Picture Viewer - {Path.GetFileName(filePath)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
        }


        private void LoadImageFolder(string folderPath)
        {
            try
            {
                // Get all image files in the folder
                imageFiles = Directory.GetFiles(folderPath, "*.*")
                                       .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                                   f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                                   f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                                   f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                                   f.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                                       .ToArray();

                // Set the current index to the selected image
                currentImageIndex = Array.IndexOf(imageFiles, openFileDialog1.FileName);
                //MessageBox.Show("CurrentImageIndex:" + currentImageIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image folder: {ex.Message}");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (imageFiles == null || imageFiles.Length == 0)
            {
                MessageBox.Show("No images loaded. Please open a folder with images first.");
                return;
            }

            // Decrement the index and wrap around if necessary
            currentImageIndex = (currentImageIndex - 1 + imageFiles.Length) % imageFiles.Length;

            // Load the previous image
            LoadImage(imageFiles[currentImageIndex]);
        }

        private void fullScreenButton_Click(object sender, EventArgs e)
        {
            if (isFullScreen)
            {
                // Exit full-screen mode
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                isFullScreen = false;
                fullScreenButton.Text = "Full Screen";
            }
            else
            {
                // Enter full-screen mode
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                isFullScreen = true;
                fullScreenButton.Text = "Exit Full Screen";
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape && isFullScreen)
            {
                // Exit full-screen mode
                fullScreenButton.PerformClick();
                return true; // Indicate the key press was handled
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image loaded. Please load an image first.");
                return;
            }

            Image image = pictureBox1.Image;
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            pictureBox1.Image = image;
            pictureBox1.Refresh();
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to save. Please load an image first.");
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Bitmap tempBitmap = new Bitmap(pictureBox1.Image))
                    {
                        tempBitmap.Save(saveFileDialog1.FileName); // , System.Drawing.Imaging.ImageFormat.Png);
                        //pictureBox1.Image.Save(saveFileDialog1.FileName);
                    }
                    //pictureBox1.Image.Save(saveFileDialog1.FileName);
                    MessageBox.Show("Image saved successfully!");
                    LoadImageFolder(Path.GetDirectoryName(openFileDialog1.FileName));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving the image: " + ex);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to save. Please load an image first.");
                return;
            }
            
            if (string.IsNullOrEmpty(currentImagePath))
            {
                MessageBox.Show("No valid file path available to save the image.");
                return;
            }

            try
            {
                using (Bitmap tempBitmap = new Bitmap(pictureBox1.Image))
                {
                    using (FileStream fs = new FileStream(currentImagePath, FileMode.Create, FileAccess.Write))
                    {
                        tempBitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }

                // Save the image to the original file path
                //using (FileStream fs = new FileStream(currentImagePath, FileMode.Create, FileAccess.Write))
                //{
                //    pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                //}

                MessageBox.Show($"Image saved successfully to: {currentImagePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving the image: " + ex);
            }
        }
    }
}
