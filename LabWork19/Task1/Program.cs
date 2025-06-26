using Task1;

int number1 = 3;
int number2 = 2;

Context context = new(new OperationAdd());
Console.WriteLine($"OpearationAdd: {context.ExecuteStrategy(number1, number2)}");

context = new(new OperationSubstract());
Console.WriteLine($"OperationSubstract: {context.ExecuteStrategy(number1, number2)}");

context = new(new OperationMultiply());
Console.WriteLine($"OperationMultiply: {context.ExecuteStrategy(number1, number2)}");

context = new(new OperationDivide());
Console.WriteLine($"OperationDivision: {context.ExecuteStrategy(number1, number2)}");