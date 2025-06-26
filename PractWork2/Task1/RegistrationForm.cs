namespace Task1
{
    public partial class RegistrationForm : Form
    {
        private const string CsvFilePath = "logins.cvs";

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text.Trim();
            string password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Логин или пароль не могут быть пустыми!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsLoginExists(login))
            {
                MessageBox.Show("Этот логин уже занят.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegisterNewUser(login, password);

            MessageBox.Show("Регистрация прошла успешно!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputFields();
        }

        private static bool IsLoginExists(string login)
        {
            if (!File.Exists(CsvFilePath))
                return false;

            string[] existingEntries = File.ReadAllLines(CsvFilePath);

            foreach (string entry in existingEntries)
            {
                string[] parts = entry.Split(';');
                if (parts.Length > 0 && parts[0].Equals(login, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }

        private static void RegisterNewUser(string login, string password)
        {
            string registrationDate = DateTime.Now.ToString();
            string newEntry = $"{login};{password};{registrationDate}{Environment.NewLine}";

            File.AppendAllText(CsvFilePath, newEntry);
        }

        private void ClearInputFields()
        {
            LoginTextBox.Clear();
            PasswordTextBox.Clear();
            LoginTextBox.Focus();
        }
    }
}
