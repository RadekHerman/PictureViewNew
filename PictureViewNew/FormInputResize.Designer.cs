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
            messageTextBox = new TextBox();
            label1 = new Label();
            widthBox = new TextBox();
            okButton = new Button();
            widthLabel = new Label();
            heightLabel = new Label();
            heightBox = new TextBox();
            SuspendLayout();
            // 
            // messageTextBox
            // 
            messageTextBox.BorderStyle = BorderStyle.None;
            messageTextBox.Enabled = false;
            messageTextBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            messageTextBox.Location = new Point(15, 5);
            messageTextBox.Margin = new Padding(4, 5, 4, 5);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.ReadOnly = true;
            messageTextBox.Size = new Size(544, 82);
            messageTextBox.TabIndex = 0;
            messageTextBox.TabStop = false;
            messageTextBox.Text = "Please enter desired height and width. The values will remain proportional.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(449, 375);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // widthBox
            // 
            widthBox.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            widthBox.Location = new Point(136, 86);
            widthBox.Margin = new Padding(4, 5, 4, 5);
            widthBox.MaxLength = 5;
            widthBox.Name = "widthBox";
            widthBox.Size = new Size(188, 40);
            widthBox.TabIndex = 2;
            widthBox.TextAlign = HorizontalAlignment.Center;
            // 
            // okButton
            // 
            okButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            okButton.Location = new Point(370, 120);
            okButton.Margin = new Padding(4, 5, 4, 5);
            okButton.Name = "okButton";
            okButton.Size = new Size(138, 49);
            okButton.TabIndex = 3;
            okButton.Text = "Submit";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            widthLabel.Location = new Point(18, 92);
            widthLabel.Margin = new Padding(4, 0, 4, 0);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(79, 32);
            widthLabel.TabIndex = 4;
            widthLabel.Text = "width";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            heightLabel.Location = new Point(18, 162);
            heightLabel.Margin = new Padding(4, 0, 4, 0);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(91, 32);
            heightLabel.TabIndex = 5;
            heightLabel.Text = "height";
            // 
            // heightBox
            // 
            heightBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            heightBox.Location = new Point(138, 159);
            heightBox.Margin = new Padding(4, 4, 4, 4);
            heightBox.MaxLength = 5;
            heightBox.Name = "heightBox";
            heightBox.Size = new Size(186, 39);
            heightBox.TabIndex = 6;
            heightBox.TextAlign = HorizontalAlignment.Center;
            // 
            // FormInputResize
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 242);
            Controls.Add(heightBox);
            Controls.Add(heightLabel);
            Controls.Add(widthLabel);
            Controls.Add(okButton);
            Controls.Add(widthBox);
            Controls.Add(label1);
            Controls.Add(messageTextBox);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(582, 298);
            MinimumSize = new Size(582, 298);
            Name = "FormInputResize";
            Text = "Set Resize Values";
            Load += FormInputResize_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox messageTextBox;
        private Label label1;
        private TextBox widthBox;
        private Button okButton;
        private Label widthLabel;
        private Label heightLabel;
        private TextBox heightBox;
    }
}