class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string Address { get; set; }
    public string Category { get; set; }
    public bool IsArchived { get; set; }
    public string HiddenPassword => new('•', Password.Length);
}
