namespace PictureViewNew
{
    public partial class FormMain : Form
    {
        private string[]? imageFiles;
        private int currentImageIndex = -1;
        private bool isFullScreen = false;
        private string currentImagePath = string.Empty;
        //private int maxSize = 1000;


        public FormMain()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += FormMain_KeyDown;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentImagePath = openFileDialog1.FileName;

                using (FileStream fs = new FileStream(currentImagePath, FileMode.Open))
                {
                    pictureBox1.Image = Image.FromStream(fs);
                }

                this.Text = $"Picture Viewer - {Path.GetFileName(openFileDialog1.FileName)}";
                string directory = Path.GetDirectoryName(openFileDialog1.FileName) ?? Environment.CurrentDirectory;
                LoadImageFolder(directory);
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
                        tempBitmap.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    MessageBox.Show("Image saved successfully!");
                    string directory = Path.GetDirectoryName(openFileDialog1.FileName) ?? Environment.CurrentDirectory;
                    LoadImageFolder(directory);
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
                    using FileStream fs = new FileStream(currentImagePath, FileMode.Create, FileAccess.Write);
                    tempBitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                MessageBox.Show($"Image saved successfully to: {currentImagePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving the image: {ex}");
            }
        }

        private void resizeButton_Click(object sender, EventArgs e)
        {
            int maxSize = FormInputResize.resizeValue;
            //int maxSize = FormInputResize.LoadUserValue();


            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please open a picture first.");
                return;
            }

            using (Bitmap tempBitmap = new Bitmap(pictureBox1.Image))
            {
                try
                {
                    Bitmap processedImage = ResizeImage(tempBitmap, maxSize);
                    pictureBox1.Image = processedImage;
                    MessageBox.Show($"The image has been resized to {maxSize}");
                }
                catch (Exception)
                {
                    MessageBox.Show($"Please give a different resize value.");
                }   
            }
        }

        private Bitmap ResizeImage(Bitmap image, int targetSize)
        {
            float scale = Math.Min((float)targetSize / image.Width, (float)targetSize / image.Height);
            int newWidth = (int)(image.Width * scale);
            int newHeight = (int)(image.Height * scale);

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }

        // key down 

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl+S for Save
            {
                saveButton_Click(sender, e);
                e.Handled = true;
            }

            else if (e.Control && e.KeyCode == Keys.A) // Ctrl+Z for Save As
            {
                saveAsButton_Click(sender, e);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.R) // Ctrl+R for Rotate
            {
                rotateButton_Click(sender, e);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.O) // Ctrl+O for Open
            {
                openButton_Click(sender, e);
                e.Handled = true;
            }

            else if (e.Control && e.KeyCode == Keys.Q) // Ctrl+Q for Resize
            {
                resizeButton_Click(sender, e);
                e.Handled = true;
            }

            else if (e.Control && e.KeyCode == Keys.X) // Ctrl+X for Exit
            {
                exitMenuItem_Click(sender, e);
                e.Handled = true;
            }

            else if (e.Control && e.KeyCode == Keys.N) // Ctrl+N for Next
            {
                nextButton_Click(sender, e);
                e.Handled = true;
            }

            else if (e.Control && e.KeyCode == Keys.B) // Ctrl+X for Previous
            {
                previousButton_Click(sender, e);
                e.Handled = true;
            }

            else if (e.Control && e.KeyCode == Keys.F) // Ctrl+X for Previous
            {
                fullScreenButton_Click(sender, e);
                e.Handled = true;
            }

            else if (e.Control && e.KeyCode == Keys.L) // Ctrl+X for Previous
            {
                closeButton_Click(sender, e);
                e.Handled = true;
            }

        }



        // strip menu methods
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            openButton_Click(sender, e);
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            closeButton_Click(sender, e);
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fullScreenMenuItem_Click(object sender, EventArgs e)
        {
            fullScreenButton_Click(sender, e);
        }

        private void rotateMenuItem_Click(object sender, EventArgs e)
        {
            rotateButton_Click(sender, e);
        }

        private void nextImageMenuItem_Click(object sender, EventArgs e)
        {
            nextButton_Click(sender, e);
        }

        private void previousImageMenuItem_Click(object sender, EventArgs e)
        {
            previousButton_Click(sender, e);
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            saveButton_Click(sender, e);
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            saveAsButton_Click(sender, e);
        }

        private void backgroundColorMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                text: "View your pictures, rotate, resize and save if needed." +
                      "\nCopyright (c) 2024 Rados³aw Herman",
                caption: "About ImageViewApp",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information
                );
        }

        private void resizeSettingsMenuItem_Click(object sender, EventArgs e)
        {
            FormInputResize form2 = new FormInputResize();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show($"Resize set to: {FormInputResize.resizeValue}");
            }
        }
    }
}
