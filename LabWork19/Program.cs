Context context = new(new OperationAdd());
Console.WriteLine($"25 + 5 = {context.ExecuteStrategy(25, 5)}");

context.SetStrategy(new OperationMultiply());
Console.WriteLine($"25 * 5 = {context.ExecuteStrategy(25, 5)}");

context.SetStrategy(new OperationSubstract());
Console.WriteLine($"25 - 5 = {context.ExecuteStrategy(25, 5)}");

context.SetStrategy(new OperationDivision());
Console.WriteLine($"25 / 5 = {context.ExecuteStrategy(25, 5)}");
