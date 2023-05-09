

//capture users age
Console.Write("What is your age: ");

//parse to int
int.TryParse(Console.ReadLine(), out int age);

//print to console
Console.WriteLine($"In 25 years, you will be {age + 25} years old.\n25 years ago, you were {age - 25} years old.");