namespace PictureViewNew
{
    public partial class Form1 : Form
    {
        private string[] imageFiles; // Array to store image file paths
        private int currentImageIndex = -1; // Index of the currently displayed image
        public Form1()
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
                pictureBox1.Load(openFileDialog1.FileName);
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
                pictureBox1.Image = Image.FromFile(filePath);
                this.Text = $"Picture Viewer - {Path.GetFileName(filePath)}"; // Update form title
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


    }
}
