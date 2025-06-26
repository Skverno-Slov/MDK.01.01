using System.Runtime.CompilerServices;

class User
{
    string? _login;
    string? _password;

    public string? Login
    {
        get => _login;
        set
        {
            if (_login != value)
            {
                _login = value;
                string errorText = (_login == "") ? "Логин не может быть пустым" : "";
                OnPropertyChanged(errorText);
            }
        }
    }

    public string? Password
    {
        get => _password;
        set
        {
            if (_password != value)
            {
                _password = value;
                string errorText = (_password.Length < 6) ? "Пароль слишком короткий" : (_password.Length > 20) ? "Пароль слишком длинный" : "";
                OnPropertyChanged(errorText);
            }
        }
    }

    private void OnPropertyChanged(string errorText, [CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new InfoEventArgs(propertyName, errorText, DateTime.Now));
    }

    public event EventHandler<InfoEventArgs> PropertyChanged;
}

