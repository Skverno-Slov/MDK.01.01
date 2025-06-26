User user = new() { Login = "admin", Password = "qwerty" };

user.PropertyChanged += User_PropertyChanged;
user.Login = "admin";
user.Login = " ";
user.Password = "123";
user.Password = "1234567723424234234234234234234234234";
user.Password = "123456787";

void User_PropertyChanged(object sender, InfoEventArgs e)
{
    User user = (User)sender;
    Console.WriteLine($"{e.ChangeDate} у пользователя {user.Login} изменено {e.PropertyName}");
    if (e.ErrorText == "")
        Console.WriteLine($"Ошибка: {e.ErrorText}");
}
