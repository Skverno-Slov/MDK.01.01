Patient patient1 = new() { FullName = "Иванов Иван Иванович", Policy = "1231232", BirthDate = new(605, 12, 4) };
Patient patient2 = new() { FullName = "Сергеев Сергей Сергеевич", Policy = "123123212", BirthDate = new(1605, 4, 12) };
Console.WriteLine(patient1);
Console.WriteLine(patient2);