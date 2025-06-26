class InfoEventArgs
{
    public string PropertyName { get; }
    public string ErrorText { get; }
    public DateTime ChangeDate { get; }

    public InfoEventArgs(string propertyName, string errorText, DateTime changeDate)
    {
        PropertyName = propertyName;
        ErrorText = errorText;
        ChangeDate = changeDate;
    }
}
