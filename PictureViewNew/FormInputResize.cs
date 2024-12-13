namespace PictureViewNew
{
    public partial class FormInputResize : Form
    {

        public string InputValue
        {
            get { return inputValueTextBox.Text; }
        }

        public FormInputResize(int currentValue)
        {
            InitializeComponent();
            inputValueTextBox.KeyPress += inputValueTextBox_KeyPress;
            inputValueTextBox.Text = currentValue.ToString();
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
            this.DialogResult = DialogResult.OK; // Indicate success
            inputValueTextBox.Text = inputValueTextBox.Text;
            this.Close();
        }
    }
}
