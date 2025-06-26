User user = new() { Login = "admin", Password = "qwerty" };

user.PropertyChanged += User_PropertyChanged;
user.Login = "admin";
user.Login = "user";
user.Login = "admin";
user.Password = "admin";

void User_PropertyChanged(object sender, EventArgs e)
{
    User user = (User)sender;
    Console.WriteLine($"Изменились данные пользователя со следующим логином: {user.Login}");
}
