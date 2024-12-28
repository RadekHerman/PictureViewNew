using System.Windows.Forms;

namespace PictureViewNew
{
    public partial class FormInputResize : Form
    {

        private int pictureWidth;
        private int pictureHeight;
        public static int resizeHeight { get; set; }
        public static int resizeWidth
        {
            get
            {
                return Properties.Settings.Default.UserResizeWidth;
            }
            set
            {
                Properties.Settings.Default.UserResizeWidth = value;
                Properties.Settings.Default.Save();
            }
        }

        public FormInputResize(int width, int height)
        {
            InitializeComponent();
            pictureWidth = width;
            pictureHeight = height;
            widthBox.Text = resizeWidth.ToString();
            widthBox.KeyPress += inputDigitsOnly_KeyPress;
            heightBox.KeyPress += inputDigitsOnly_KeyPress;
            widthBox.KeyDown += widthBox_KeyDown;
            heightBox.KeyDown += heightBox_KeyDown;
            widthBox.Leave += widthBox_Leave;
            heightBox.Leave += heightBox_Leave;
        }

        private void FormInputResize_Load(object sender, EventArgs e)
        {
            widthBox.Focus();
            widthBox_Leave(sender, e); /// setting height Box value
        }


        // Event handler for KeyPress to allow only digits
        private void inputDigitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits and control keys (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Reject the input
            }
        }

        private void widthBox_Leave(object sender, EventArgs e)
        {
            KeyEventArgs enterKeyEvent = new KeyEventArgs(Keys.Enter);
            widthBox_KeyDown(sender, enterKeyEvent);
        }

        private void heightBox_Leave(object sender, EventArgs e)
        {
            KeyEventArgs enterKeyEvent = new KeyEventArgs(Keys.Enter);
            heightBox_KeyDown(sender, enterKeyEvent);
        }


        private void widthBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(widthBox.Text))
                {
                    resizeWidth = Convert.ToInt32(widthBox.Text);
                    float scale = (float)resizeWidth / pictureWidth;
                    resizeHeight = (int)Math.Round(pictureHeight * scale);
                    heightBox.Text = resizeHeight.ToString();
                }
                e.SuppressKeyPress = true;
            }
        }

        private void heightBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(heightBox.Text))
                {
                    resizeHeight = Convert.ToInt32(heightBox.Text);
                    float scale = (float)resizeHeight / pictureHeight;
                    resizeWidth = (int)Math.Round(pictureWidth * scale);
                    widthBox.Text = resizeWidth.ToString();
                }
                e.SuppressKeyPress = true;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(widthBox.Text, out int submittedWidth))
            {
                if (submittedWidth > 1)
                {
                    resizeWidth = submittedWidth;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Value should be more than 1");
                }
            }
            else if (int.TryParse(heightBox.Text, out int submittedHeight))
            {
                if (submittedHeight > 1)
                {
                    resizeHeight = submittedHeight;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Value should be more than 1");
                }
            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
        }
    }
}
