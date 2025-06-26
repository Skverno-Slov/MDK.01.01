namespace Task3
{
    public partial class ReplacementForm : Form
    {
        public Action<string, string> Replacement;

        public ReplacementForm()
        {
            InitializeComponent();
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            Replacement?.Invoke(SearchTextBox.Text, ReplacementTextBox.Text);
        }
    }
}
