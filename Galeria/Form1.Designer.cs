namespace Galeria
{
    partial class mainWindow
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
            paintingTitle = new Label();
            painting = new PictureBox();
            paintingAuthor = new Label();
            paintingQuote = new Label();
            nextButton = new Button();
            prevButton = new Button();
            ((System.ComponentModel.ISupportInitialize)painting).BeginInit();
            SuspendLayout();
            // 
            // paintingTitle
            // 
            paintingTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            paintingTitle.AutoSize = true;
            paintingTitle.Font = new Font("Segoe UI", 27F, FontStyle.Regular, GraphicsUnit.Pixel);
            paintingTitle.Location = new Point(285, 273);
            paintingTitle.Name = "paintingTitle";
            paintingTitle.Size = new Size(182, 37);
            paintingTitle.TabIndex = 0;
            paintingTitle.Text = "Charlie Brown";
            // 
            // painting
            // 
            painting.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            painting.ImageLocation = "";
            painting.InitialImage = null;
            painting.Location = new Point(285, 70);
            painting.Name = "painting";
            painting.Size = new Size(200, 200);
            painting.SizeMode = PictureBoxSizeMode.StretchImage;
            painting.TabIndex = 1;
            painting.TabStop = false;
            // 
            // paintingAuthor
            // 
            paintingAuthor.Anchor = AnchorStyles.None;
            paintingAuthor.AutoSize = true;
            paintingAuthor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Pixel);
            paintingAuthor.Location = new Point(348, 310);
            paintingAuthor.Name = "paintingAuthor";
            paintingAuthor.Size = new Size(56, 12);
            paintingAuthor.TabIndex = 2;
            paintingAuthor.Text = "Mauro Lopes";
            paintingAuthor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // paintingQuote
            // 
            paintingQuote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            paintingQuote.AutoSize = true;
            paintingQuote.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            paintingQuote.Location = new Point(270, 338);
            paintingQuote.Name = "paintingQuote";
            paintingQuote.Size = new Size(213, 25);
            paintingQuote.TabIndex = 3;
            paintingQuote.Text = "\"O fracasso é inevitável.\"";
            paintingQuote.Click += paintingQuote_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(439, 396);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(75, 23);
            nextButton.TabIndex = 4;
            nextButton.Text = "->";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // prevButton
            // 
            prevButton.Location = new Point(253, 396);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(75, 23);
            prevButton.TabIndex = 5;
            prevButton.Text = "<-";
            prevButton.UseVisualStyleBackColor = true;
            prevButton.Click += prevButton_Click;
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(prevButton);
            Controls.Add(nextButton);
            Controls.Add(paintingQuote);
            Controls.Add(paintingAuthor);
            Controls.Add(painting);
            Controls.Add(paintingTitle);
            Name = "mainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Galeria";
            Load += mainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)painting).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label paintingTitle;
        private PictureBox painting;
        private Label paintingAuthor;
        private Label paintingQuote;
        private Button nextButton;
        private Button prevButton;
    }
}
