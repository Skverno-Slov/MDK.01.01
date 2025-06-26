DirectoryInfo directory = new(@"C:\temp\ispp31");
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
var files1 = files
    .Select(file => new { file.Name, file.DirectoryName, file.Length, file.CreationTime })
    .OrderBy(file => file.Name)
    .ThenByDescending(file => file.CreationTime);

string text = Console.ReadLine();
if (text != string.Empty)
{
    var files2 = files
        .Where(file => file.Name.Contains(text));

    var countFiles = files
        .Count(file => file.Name == text);
}
else
    Console.WriteLine("Строка пустая");

var files4 = files
    .Select(file => file.Extension)
    .Distinct();

var files5 = files
    .GroupBy(file => file.Extension)
    .Select(group => new { Extensions = group.Key, Count = group.Count() });

var files6 = files
    .Where(file => file.CreationTime <= DateTime.Now)
    .OrderByDescending(file => file.CreationTime)
    .Take(10);

var files7 = files
    .Select(file => new
    {
        file.Name,
        file.Extension,
        file.DirectoryName,
        Lenght = file.Length < 1024 ? $"{file.Length} Б"
        : file.Length < 1048576 ? $"{file.Length >> 10} КБ"
        : $"{file.Length >> 20} МБ"
    });