internal class Patient
{
    public string? FullName { get; set; }
    public string? Policy { get; set; }
    public DateTime BirthDate { get; set; }

    public override string ToString()
    {
        string? newPolicy = Policy;
        while (newPolicy.Length < 9)
            newPolicy = 0 + newPolicy;
        return $"{FullName.ToUpper()};{newPolicy};{BirthDate:yyyy/MM/dd}";
    }
}