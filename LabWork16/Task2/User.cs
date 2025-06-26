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
                PropertyChanged?.Invoke(this, EventArgs.Empty);
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
                PropertyChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public event EventHandler PropertyChanged;
}