namespace PractWork3
{
    public partial class CreateWordDocumentForm : Form
    {
        WordMeneger meneger = new();

        public CreateWordDocumentForm()
        {
            InitializeComponent();
        }


        private void CreateDocumentButton_Click(object sender, EventArgs e)
        {
            meneger.OverrideTemplateDocument(InputTextBox.Text, (int)InputTaskCountNumericUpDown.Value);
        }

        private void CreateNewDocumentButton_Click(object sender, EventArgs e)
        {
            meneger.CreateNewDocument(InputTextBox.Text, (int)InputTaskCountNumericUpDown.Value);
        }
    }
}
