namespace PictureViewNew
{
    partial class FormMain
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
            fullScreenButton = new Button();
            closeButton = new Button();
            rotateButton = new Button();
            openButton = new Button();
            previousButton = new Button();
            nextButton = new Button();
            saveButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
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
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(618, 488);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Controls.Add(fullScreenButton, 0, 0);
            tableLayoutPanel1.Controls.Add(closeButton, 4, 0);
            tableLayoutPanel1.Controls.Add(rotateButton, 5, 0);
            tableLayoutPanel1.Controls.Add(openButton, 3, 0);
            tableLayoutPanel1.Controls.Add(previousButton, 2, 0);
            tableLayoutPanel1.Controls.Add(nextButton, 1, 0);
            tableLayoutPanel1.Controls.Add(saveButton, 6, 0);
            tableLayoutPanel1.Cursor = Cursors.Hand;
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 433);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(11, 7, 11, 7);
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(618, 55);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // fullScreenButton
            // 
            fullScreenButton.AutoSize = true;
            fullScreenButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            fullScreenButton.Location = new Point(514, 11);
            fullScreenButton.Margin = new Padding(3, 4, 3, 4);
            fullScreenButton.Name = "fullScreenButton";
            fullScreenButton.Size = new Size(90, 30);
            fullScreenButton.TabIndex = 6;
            fullScreenButton.Text = "Full Screen";
            fullScreenButton.UseVisualStyleBackColor = true;
            fullScreenButton.Click += fullScreenButton_Click;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            closeButton.Location = new Point(146, 11);
            closeButton.Margin = new Padding(3, 4, 3, 4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(101, 30);
            closeButton.TabIndex = 2;
            closeButton.Text = "Close Image";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // rotateButton
            // 
            rotateButton.AutoSize = true;
            rotateButton.Location = new Point(68, 11);
            rotateButton.Margin = new Padding(3, 4, 3, 4);
            rotateButton.Name = "rotateButton";
            rotateButton.Size = new Size(72, 33);
            rotateButton.TabIndex = 1;
            rotateButton.Text = "Rotate";
            rotateButton.UseVisualStyleBackColor = true;
            rotateButton.Click += rotateButton_Click;
            // 
            // openButton
            // 
            openButton.AutoSize = true;
            openButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openButton.Location = new Point(253, 11);
            openButton.Margin = new Padding(3, 4, 3, 4);
            openButton.Name = "openButton";
            openButton.Size = new Size(101, 30);
            openButton.TabIndex = 3;
            openButton.Text = "Open Image";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // previousButton
            // 
            previousButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            previousButton.Location = new Point(360, 11);
            previousButton.Margin = new Padding(3, 4, 3, 4);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(71, 33);
            previousButton.TabIndex = 4;
            previousButton.Text = "Previous";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // nextButton
            // 
            nextButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nextButton.Location = new Point(437, 11);
            nextButton.Margin = new Padding(3, 4, 3, 4);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(71, 33);
            nextButton.TabIndex = 5;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // saveButton
            // 
            saveButton.AutoSize = true;
            saveButton.Location = new Point(14, 11);
            saveButton.Margin = new Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(48, 33);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 4;
            openFileDialog1.Title = "Open an image file";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 4;
            // 
            // FormMain
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(618, 488);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(634, 51);
            Name = "FormMain";
            Text = "Image Viewer";
            Load += Form1_Load;
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
        private Button rotateButton;
        private Button fullScreenButton;
        protected TableLayoutPanel tableLayoutPanel1;
        private OpenFileDialog openFileDialog1;
        private Button saveButton;
        private SaveFileDialog saveFileDialog1;
    }
}
