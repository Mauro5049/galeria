namespace Galeria
{
    using System.Diagnostics;
    using Microsoft.WindowsAPICodePack.Shell;
    using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

    public partial class mainWindow : Form
    {

        string fallbackImagePath = "C:\\Users\\CJ3027538\\Pictures\\igor.png";
        string fallbackImageName = "Obra sem titulo";
        string fallbackAuthorName = "Autor anonimo";
        string fallbackQuote = "Sem frase.";

        string imageDirectory = "C:\\Users\\CJ3027538\\Pictures";

        List<string> currentFiles = new List<string>();

        int imageIndex = 0;

        public mainWindow()
        {
            InitializeComponent();
            loadImages();
        }

        private void loadImages()
        {
            if (Directory.Exists(imageDirectory))
            {
                foreach (var file in Directory.GetFiles(imageDirectory))
                {
                    if (file.Contains(".png"))
                    {
                        currentFiles.Add(file);
                    }
                }
            }
        }

        private int centerText(Label text)
        {
            Size textSize = TextRenderer.MeasureText(text.Text, text.Font);
            return (this.ClientSize.Width - textSize.Width) / 2;
        }

        private void changeImage(string newImagePath)
        {
            painting.ImageLocation = newImagePath;
            paintingQuote.Text = fallbackQuote;
            paintingAuthor.Text = fallbackAuthorName;
            paintingTitle.Text = fallbackImageName;
            ShellObject painting_info = ShellObject.FromParsingName(newImagePath);
            var imageQuote = painting_info.Properties.GetProperty(SystemProperties.System.Comment);
            var imageName = painting_info.Properties.GetProperty(SystemProperties.System.Title);
            var imageAuthors = painting_info.Properties.GetProperty(SystemProperties.System.Author).ValueAsObject as string[];
            if (imageQuote != null && imageAuthors != null && imageQuote != null)
            {
                paintingQuote.Text = imageQuote.ValueAsObject.ToString();
                paintingTitle.Text = imageName.ValueAsObject.ToString();
                var imageAuthor = String.Join(",", imageAuthors);
                paintingAuthor.Text = imageAuthor;
            }
            paintingTitle.Location = new Point(centerText(paintingTitle), paintingTitle.Location.Y);
            paintingQuote.Location = new Point(centerText(paintingQuote), paintingQuote.Location.Y);
            paintingAuthor.Location = new Point(centerText(paintingAuthor), paintingAuthor.Location.Y);
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            if (currentFiles.Count == 0)
            {
                changeImage(fallbackImagePath);
            }
            else
            {
                changeImage(currentFiles[imageIndex]);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (imageIndex < currentFiles.Count - 1)
            {
                imageIndex++;
                changeImage(currentFiles[imageIndex]);
            }
        }

        private void paintingQuote_Click(object sender, EventArgs e)
        {
           
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (imageIndex > 0)
            {
                imageIndex--;
                changeImage(currentFiles[imageIndex]);
            }
        }
    }
}
