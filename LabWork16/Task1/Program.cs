using System.ComponentModel;

User user = new() { Login = "admin", Password = "qwerty" };

user.PropertyChanged += User_PropertyChanged;
user.Login = "admin";
user.Login = "user";
user.Login = "admin";

void User_PropertyChanged(object sender, PropertyChangedEventArgs e)
{
    Console.WriteLine($"Изменилось свойство {e.PropertyName}");
}
