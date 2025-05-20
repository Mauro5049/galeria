namespace Galeria
{
    using System.Diagnostics;
    using Microsoft.WindowsAPICodePack.Shell;
    using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

    // using MetadataExtractor;
    public partial class mainWindow : Form
    {
        string fallbackImagePath = "C:\\Users\\CJ3027538\\Pictures\\charlie brown.png";
        string fallbackImageName = "Obra sem titulo";
        string fallbackAuthorName = "Autor anonimo";
        string fallbackQuote = "O fracasso é inevitável.";
        public mainWindow()
        {
            InitializeComponent();
        }

        private void changeImage(string newImagePath)
        {
            painting.ImageLocation = newImagePath;
            ShellObject painting_info = ShellObject.FromParsingName(newImagePath);
            string funny = painting_info.Properties.GetProperty(SystemProperties.System.Author);
            
            //Debug.WriteLine();
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
    }
}
