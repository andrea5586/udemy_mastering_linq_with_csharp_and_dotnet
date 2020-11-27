<Query Kind="Statements" />

var numbers = new[]{ 3, 3, 2, 2, 1, 1, 2, 2, 3, 3 };

Console.WriteLine(numbers.Skip(2).Take(6));

Console.WriteLine(new int[]{}.Take(2));

Console.WriteLine(numbers.SkipWhile(i => i == 3));
Console.WriteLine(numbers.TakeWhile(i => i > 1));