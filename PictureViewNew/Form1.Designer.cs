namespace PictureViewNew
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            fullscreenButton = new Button();
            closeButton = new Button();
            propertiesButton = new Button();
            openButton = new Button();
            previousButton = new Button();
            nextButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(520, 378);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(fullscreenButton, 0, 0);
            tableLayoutPanel1.Controls.Add(closeButton, 4, 0);
            tableLayoutPanel1.Controls.Add(propertiesButton, 5, 0);
            tableLayoutPanel1.Controls.Add(openButton, 3, 0);
            tableLayoutPanel1.Controls.Add(previousButton, 2, 0);
            tableLayoutPanel1.Controls.Add(nextButton, 1, 0);
            tableLayoutPanel1.Cursor = Cursors.Hand;
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 327);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(520, 51);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // fullscreenButton
            // 
            fullscreenButton.AutoSize = true;
            fullscreenButton.Location = new Point(432, 13);
            fullscreenButton.Name = "fullscreenButton";
            fullscreenButton.Size = new Size(75, 25);
            fullscreenButton.TabIndex = 5;
            fullscreenButton.Text = "Full Screen";
            fullscreenButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Location = new Point(94, 13);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(82, 25);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close Image";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // propertiesButton
            // 
            propertiesButton.AutoSize = true;
            propertiesButton.Location = new Point(13, 13);
            propertiesButton.Name = "propertiesButton";
            propertiesButton.Size = new Size(75, 25);
            propertiesButton.TabIndex = 4;
            propertiesButton.Text = "Properties";
            propertiesButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            openButton.AutoSize = true;
            openButton.Location = new Point(182, 13);
            openButton.Name = "openButton";
            openButton.Size = new Size(82, 25);
            openButton.TabIndex = 0;
            openButton.Text = "Open Image";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // previousButton
            // 
            previousButton.AutoSize = true;
            previousButton.Location = new Point(270, 13);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(75, 25);
            previousButton.TabIndex = 2;
            previousButton.Text = "Previous";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // nextButton
            // 
            nextButton.AutoSize = true;
            nextButton.Location = new Point(351, 13);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(75, 25);
            nextButton.TabIndex = 3;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.Title = "Open an image file";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(520, 378);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            MinimumSize = new Size(536, 50);
            Name = "Form1";
            Text = "Image Viewer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button openButton;
        private Button closeButton;
        private Button previousButton;
        private Button nextButton;
        private Button propertiesButton;
        private Button fullscreenButton;
        protected TableLayoutPanel tableLayoutPanel1;
        private OpenFileDialog openFileDialog1;
    }
}
