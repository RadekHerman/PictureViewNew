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
            messageTextBox.Location = new Point(12, 4);
            messageTextBox.Margin = new Padding(3, 4, 3, 4);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.ReadOnly = true;
            messageTextBox.Size = new Size(435, 66);
            messageTextBox.TabIndex = 0;
            messageTextBox.TabStop = false;
            messageTextBox.Text = "Please enter desired height and width. The values will keep proportion.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 300);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // widthBox
            // 
            widthBox.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            widthBox.Location = new Point(109, 69);
            widthBox.Margin = new Padding(3, 4, 3, 4);
            widthBox.MaxLength = 5;
            widthBox.Name = "widthBox";
            widthBox.Size = new Size(151, 35);
            widthBox.TabIndex = 2;
            widthBox.TextAlign = HorizontalAlignment.Center;
            // 
            // okButton
            // 
            okButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            okButton.Location = new Point(296, 96);
            okButton.Margin = new Padding(3, 4, 3, 4);
            okButton.Name = "okButton";
            okButton.Size = new Size(110, 39);
            okButton.TabIndex = 3;
            okButton.Text = "Submit";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            widthLabel.Location = new Point(14, 74);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(62, 26);
            widthLabel.TabIndex = 4;
            widthLabel.Text = "width";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            heightLabel.Location = new Point(14, 130);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(72, 26);
            heightLabel.TabIndex = 5;
            heightLabel.Text = "height";
            // 
            // heightBox
            // 
            heightBox.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            heightBox.Location = new Point(110, 127);
            heightBox.MaxLength = 5;
            heightBox.Name = "heightBox";
            heightBox.Size = new Size(150, 34);
            heightBox.TabIndex = 6;
            heightBox.TextAlign = HorizontalAlignment.Center;
            // 
            // FormInputResize
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 203);
            Controls.Add(heightBox);
            Controls.Add(heightLabel);
            Controls.Add(widthLabel);
            Controls.Add(okButton);
            Controls.Add(widthBox);
            Controls.Add(label1);
            Controls.Add(messageTextBox);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(470, 250);
            MinimumSize = new Size(470, 250);
            Name = "FormInputResize";
            Text = "Max Resize Value";
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