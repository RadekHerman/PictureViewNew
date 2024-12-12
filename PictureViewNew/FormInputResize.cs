using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PictureViewNew
{
    public partial class FormInputResize : Form
    {
        public string InputValue
        {
            get { return inputValueTextBox.Text; }
        }

        public FormInputResize()
        {
            InitializeComponent();
            //InputValueTextBox_Load();
            inputValueTextBox.KeyPress += inputValueTextBox_KeyPress;

        }

        private void FormInputResize_Load(object sender, EventArgs e)
        {
            inputValueTextBox.Text = "1000"; // Default value
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


    }
}
