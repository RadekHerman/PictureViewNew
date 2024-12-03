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
            openButton = new Button();
            fullButton = new Button();
            CloseButton = new Button();
            closeApp = new Button();
            nextImage = new Button();
            previousButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
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
            tableLayoutPanel1.Controls.Add(fullButton, 0, 0);
            tableLayoutPanel1.Controls.Add(CloseButton, 4, 0);
            tableLayoutPanel1.Controls.Add(nextImage, 2, 0);
            tableLayoutPanel1.Controls.Add(previousButton, 3, 0);
            tableLayoutPanel1.Controls.Add(openButton, 1, 0);
            tableLayoutPanel1.Controls.Add(closeApp, 5, 0);
            tableLayoutPanel1.Cursor = Cursors.Hand;
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 419);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 31);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // openButton
            // 
            openButton.AutoSize = true;
            openButton.Location = new Point(639, 3);
            openButton.Name = "openButton";
            openButton.Size = new Size(77, 25);
            openButton.TabIndex = 0;
            openButton.Text = "New Image";
            openButton.UseVisualStyleBackColor = true;
            // 
            // fullButton
            // 
            fullButton.AutoSize = true;
            fullButton.Location = new Point(722, 3);
            fullButton.Name = "fullButton";
            fullButton.Size = new Size(75, 25);
            fullButton.TabIndex = 5;
            fullButton.Text = "Full Screen";
            fullButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Location = new Point(389, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(82, 25);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close Image";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // closeApp
            // 
            closeApp.AutoSize = true;
            closeApp.Location = new Point(308, 3);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(75, 25);
            closeApp.TabIndex = 4;
            closeApp.Text = "Close App";
            closeApp.UseVisualStyleBackColor = true;
            // 
            // nextImage
            // 
            nextImage.AutoSize = true;
            nextImage.Location = new Point(558, 3);
            nextImage.Name = "nextImage";
            nextImage.Size = new Size(75, 25);
            nextImage.TabIndex = 3;
            nextImage.Text = "Next";
            nextImage.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            previousButton.AutoSize = true;
            previousButton.Location = new Point(477, 3);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(75, 25);
            previousButton.TabIndex = 2;
            previousButton.Text = "Previous";
            previousButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
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
        private Button CloseButton;
        private Button previousButton;
        private Button nextImage;
        private Button closeApp;
        private Button fullButton;
        protected TableLayoutPanel tableLayoutPanel1;
    }
}
