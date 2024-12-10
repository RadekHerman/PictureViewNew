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
            closeButton = new Button();
            previousButton = new Button();
            openButton = new Button();
            nextButton = new Button();
            rotateButton = new Button();
            fullScreenButton = new Button();
            saveButton = new Button();
            saveAsButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            imageToolStripMenuItem = new ToolStripMenuItem();
            openMenuItem = new ToolStripMenuItem();
            saveMenuItem = new ToolStripMenuItem();
            saveAsMenuItem = new ToolStripMenuItem();
            closeMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            fullScreenMenuItem = new ToolStripMenuItem();
            rotateMenuItem = new ToolStripMenuItem();
            nextImageMenuItem = new ToolStripMenuItem();
            previousImageMenuItem = new ToolStripMenuItem();
            resizeMenuItem = new ToolStripMenuItem();
            propertiesToolStripMenuItem = new ToolStripMenuItem();
            backgroundColorMenuItem = new ToolStripMenuItem();
            resizeSettingsMenuItem = new ToolStripMenuItem();
            aboutMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 28);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(709, 470);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(closeButton, 0, 0);
            tableLayoutPanel1.Controls.Add(previousButton, 6, 0);
            tableLayoutPanel1.Controls.Add(openButton, 7, 0);
            tableLayoutPanel1.Controls.Add(nextButton, 5, 0);
            tableLayoutPanel1.Controls.Add(rotateButton, 4, 0);
            tableLayoutPanel1.Controls.Add(fullScreenButton, 1, 0);
            tableLayoutPanel1.Controls.Add(saveButton, 3, 0);
            tableLayoutPanel1.Controls.Add(saveAsButton, 2, 0);
            tableLayoutPanel1.Cursor = Cursors.Hand;
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 443);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(11, 7, 11, 7);
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(709, 55);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            closeButton.Location = new Point(594, 11);
            closeButton.Margin = new Padding(3, 4, 3, 4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(101, 30);
            closeButton.TabIndex = 7;
            closeButton.Text = "Close Image";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // previousButton
            // 
            previousButton.AutoSize = true;
            previousButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            previousButton.Location = new Point(120, 11);
            previousButton.Margin = new Padding(3, 4, 3, 4);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(74, 30);
            previousButton.TabIndex = 1;
            previousButton.Text = "Previous";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // openButton
            // 
            openButton.AutoSize = true;
            openButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openButton.Location = new Point(13, 11);
            openButton.Margin = new Padding(3, 4, 3, 4);
            openButton.Name = "openButton";
            openButton.Size = new Size(101, 30);
            openButton.TabIndex = 0;
            openButton.Text = "Open Image";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // nextButton
            // 
            nextButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nextButton.Location = new Point(200, 11);
            nextButton.Margin = new Padding(3, 4, 3, 4);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(71, 31);
            nextButton.TabIndex = 2;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // rotateButton
            // 
            rotateButton.AutoSize = true;
            rotateButton.Location = new Point(277, 11);
            rotateButton.Margin = new Padding(3, 4, 3, 4);
            rotateButton.Name = "rotateButton";
            rotateButton.Size = new Size(72, 33);
            rotateButton.TabIndex = 3;
            rotateButton.Text = "Rotate";
            rotateButton.UseVisualStyleBackColor = true;
            rotateButton.Click += rotateButton_Click;
            // 
            // fullScreenButton
            // 
            fullScreenButton.AutoSize = true;
            fullScreenButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            fullScreenButton.Location = new Point(498, 11);
            fullScreenButton.Margin = new Padding(3, 4, 3, 4);
            fullScreenButton.Name = "fullScreenButton";
            fullScreenButton.Size = new Size(90, 30);
            fullScreenButton.TabIndex = 6;
            fullScreenButton.Text = "Full Screen";
            fullScreenButton.UseVisualStyleBackColor = true;
            fullScreenButton.Click += fullScreenButton_Click;
            // 
            // saveButton
            // 
            saveButton.AutoSize = true;
            saveButton.Location = new Point(355, 11);
            saveButton.Margin = new Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(63, 33);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // saveAsButton
            // 
            saveAsButton.AutoSize = true;
            saveAsButton.Location = new Point(424, 11);
            saveAsButton.Margin = new Padding(3, 4, 3, 4);
            saveAsButton.Name = "saveAsButton";
            saveAsButton.Size = new Size(68, 31);
            saveAsButton.TabIndex = 5;
            saveAsButton.Text = "Save as";
            saveAsButton.UseVisualStyleBackColor = true;
            saveAsButton.Click += saveAsButton_Click;
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
            saveFileDialog1.FilterIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { imageToolStripMenuItem, viewToolStripMenuItem, propertiesToolStripMenuItem, aboutMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(709, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openMenuItem, saveMenuItem, saveAsMenuItem, closeMenuItem, exitMenuItem });
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(65, 24);
            imageToolStripMenuItem.Text = "&Image";
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.Size = new Size(174, 26);
            openMenuItem.Text = "&Open Image";
            openMenuItem.Click += openMenuItem_Click;
            // 
            // saveMenuItem
            // 
            saveMenuItem.Name = "saveMenuItem";
            saveMenuItem.Size = new Size(174, 26);
            saveMenuItem.Text = "&Save";
            saveMenuItem.Click += saveMenuItem_Click;
            // 
            // saveAsMenuItem
            // 
            saveAsMenuItem.Name = "saveAsMenuItem";
            saveAsMenuItem.Size = new Size(174, 26);
            saveAsMenuItem.Text = "Sa&ve As";
            saveAsMenuItem.Click += saveAsMenuItem_Click;
            // 
            // closeMenuItem
            // 
            closeMenuItem.Name = "closeMenuItem";
            closeMenuItem.Size = new Size(174, 26);
            closeMenuItem.Text = "&Close Image";
            closeMenuItem.Click += closeMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(174, 26);
            exitMenuItem.Text = "&Exit App";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fullScreenMenuItem, rotateMenuItem, nextImageMenuItem, previousImageMenuItem, resizeMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "&View";
            // 
            // fullScreenMenuItem
            // 
            fullScreenMenuItem.Name = "fullScreenMenuItem";
            fullScreenMenuItem.Size = new Size(224, 26);
            fullScreenMenuItem.Text = "&Full Screen";
            fullScreenMenuItem.Click += fullScreenMenuItem_Click;
            // 
            // rotateMenuItem
            // 
            rotateMenuItem.Name = "rotateMenuItem";
            rotateMenuItem.Size = new Size(224, 26);
            rotateMenuItem.Text = "&Rotate 90 deg";
            rotateMenuItem.Click += rotateMenuItem_Click;
            // 
            // nextImageMenuItem
            // 
            nextImageMenuItem.Name = "nextImageMenuItem";
            nextImageMenuItem.Size = new Size(224, 26);
            nextImageMenuItem.Text = "&Next Image";
            nextImageMenuItem.Click += nextImageMenuItem_Click;
            // 
            // previousImageMenuItem
            // 
            previousImageMenuItem.Name = "previousImageMenuItem";
            previousImageMenuItem.Size = new Size(224, 26);
            previousImageMenuItem.Text = "Previo&us Image";
            previousImageMenuItem.Click += previousImageMenuItem_Click;
            // 
            // resizeMenuItem
            // 
            resizeMenuItem.Name = "resizeMenuItem";
            resizeMenuItem.Size = new Size(224, 26);
            resizeMenuItem.Text = "Resi&ze";
            // 
            // propertiesToolStripMenuItem
            // 
            propertiesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backgroundColorMenuItem, resizeSettingsMenuItem });
            propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            propertiesToolStripMenuItem.Size = new Size(90, 24);
            propertiesToolStripMenuItem.Text = "&Properties";
            // 
            // backgroundColorMenuItem
            // 
            backgroundColorMenuItem.Name = "backgroundColorMenuItem";
            backgroundColorMenuItem.Size = new Size(224, 26);
            backgroundColorMenuItem.Text = "&Background Color";
            backgroundColorMenuItem.Click += backgroundColorMenuItem_Click;
            // 
            // resizeSettingsMenuItem
            // 
            resizeSettingsMenuItem.Name = "resizeSettingsMenuItem";
            resizeSettingsMenuItem.Size = new Size(224, 26);
            resizeSettingsMenuItem.Text = "Resize Se&ttings";
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.Size = new Size(64, 24);
            aboutMenuItem.Text = "&About";
            aboutMenuItem.Click += aboutMenuItem_Click;
            // 
            // FormMain
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(709, 498);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(727, 51);
            Name = "FormMain";
            Text = "Image Viewer";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Button saveAsButton;
        private SaveFileDialog saveFileDialog1;
        private Button saveButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem openMenuItem;
        private ToolStripMenuItem closeMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem fullScreenMenuItem;
        private ToolStripMenuItem rotateMenuItem;
        private ToolStripMenuItem resizeMenuItem;
        private ToolStripMenuItem propertiesToolStripMenuItem;
        private ToolStripMenuItem backgroundColorMenuItem;
        private ToolStripMenuItem resizeSettingsMenuItem;
        private ToolStripMenuItem aboutMenuItem;
        private ToolStripMenuItem nextImageMenuItem;
        private ToolStripMenuItem previousImageMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem saveAsMenuItem;
        private ColorDialog colorDialog1;
    }
}
