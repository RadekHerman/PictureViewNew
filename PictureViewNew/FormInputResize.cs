namespace PictureViewNew
{
    public partial class FormInputResize : Form
    {
        public static int resizeValue
        {
            get
            {
                return Properties.Settings.Default.UserResizeValue;
            }
            set
            {
                Properties.Settings.Default.UserResizeValue = value;
                Properties.Settings.Default.Save();
            }
        }

        public FormInputResize()
        {
            InitializeComponent();
            inputValueTextBox.KeyPress += inputValueTextBox_KeyPress;
            inputValueTextBox.Text = resizeValue.ToString();
        }

        private void FormInputResize_Load(object sender, EventArgs e)
        {
            inputValueTextBox.Focus();
        }


        // Event handler for KeyPress to allow only digits
        private void inputValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits and control keys (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Reject the input
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputValueTextBox.Text, out int submittedValue))
            {
                if (submittedValue > 1)
                {
                    resizeValue = submittedValue;
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
