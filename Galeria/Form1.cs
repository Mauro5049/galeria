namespace Galeria
{
    using System.Diagnostics;
    using Microsoft.WindowsAPICodePack.Shell;
    using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

    // using MetadataExtractor;
    public partial class mainWindow : Form
    {
        string fallbackImagePath = "C:\\Users\\CJ3027538\\Pictures\\ostra.png";
        string fallbackImageName = "Obra sem titulo";
        string fallbackAuthorName = "Autor anonimo";
        string fallbackQuote = "Sem frase.";

        public mainWindow()
        {
            InitializeComponent();
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
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            if (painting.ImageLocation == "")
            {
                changeImage(fallbackImagePath);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
        }

        private void paintingQuote_Click(object sender, EventArgs e)
        {

        }
    }
}
