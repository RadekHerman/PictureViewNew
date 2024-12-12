namespace PictureViewNew
{
    partial class FormInputResize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInputResize));
            messageTextBox = new TextBox();
            label1 = new Label();
            inputValueTextBox = new TextBox();
            SuspendLayout();
            // 
            // messageTextBox
            // 
            messageTextBox.BorderStyle = BorderStyle.None;
            messageTextBox.Enabled = false;
            messageTextBox.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            messageTextBox.Location = new Point(12, 12);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.ReadOnly = true;
            messageTextBox.Size = new Size(375, 135);
            messageTextBox.TabIndex = 0;
            messageTextBox.TabStop = false;
            messageTextBox.Text = resources.GetString("messageTextBox.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 225);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // inputValueTextBox
            // 
            inputValueTextBox.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            inputValueTextBox.Location = new Point(123, 151);
            inputValueTextBox.MaxLength = 5;
            inputValueTextBox.Name = "inputValueTextBox";
            inputValueTextBox.Size = new Size(133, 29);
            inputValueTextBox.TabIndex = 2;
            inputValueTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // FormInputResize
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 189);
            Controls.Add(inputValueTextBox);
            Controls.Add(label1);
            Controls.Add(messageTextBox);
            MaximumSize = new Size(420, 228);
            MinimumSize = new Size(420, 228);
            Name = "FormInputResize";
            Text = "Max Resize Value";
            Load += FormInputResize_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox messageTextBox;
        private Label label1;
        private TextBox inputValueTextBox;
    }
}