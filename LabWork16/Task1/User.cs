using System.ComponentModel;
using System.Runtime.CompilerServices;

class User : INotifyPropertyChanged
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
                OnPropertyChange();
                _login = value;
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
                OnPropertyChange();
                _password = value;
            }
        }
    }

    private void OnPropertyChange([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}

