namespace Task3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenReplacementFormButton_Click(object sender, EventArgs e)
        {
            ReplacementForm form = new();
            form.Replacement = ReplaceText;
            form.ShowDialog();
        }

        private void ReplaceText(string searchText, string replasmenText)
        {
            EnterTextBox.Text = EnterTextBox.Text.Replace(searchText, replasmenText);
        }
    }
}
