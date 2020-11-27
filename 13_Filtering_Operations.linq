<Query Kind="Statements" />

var numbers = Enumerable.Range(1,10);
var evenNumbers = numbers.Where(n => n%2 == 0);
Console.WriteLine(evenNumbers);

// combine projection and filtering
var oddSquares = numbers.Select(x => x*x).Where(y => y%2 != 0);
Console.WriteLine(oddSquares);

// filter by type
object [] values = { 1, 2.5, 3, 4.56 };
var wholeNumbers = values.OfType<int>(); // try float or double
Console.WriteLine(wholeNumbers);