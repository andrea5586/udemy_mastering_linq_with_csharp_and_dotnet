<Query Kind="Statements" />

int [] numbers = { 1, 2, 3, 4, 5};
Console.WriteLine("Are all numbers > 0? " + numbers.All(x => x > 0));
Console.WriteLine("Are all numbers odd? " + numbers.All(x => x%2 == 1));

// once the iterator finds a match, it doesn't check other elements
Console.WriteLine("Any number less than two? " + numbers.Any(x => x < 2));

// also, Any() is a way to check whether a collection is empty
Console.WriteLine(new int[]{/*42*/}.Any());

Console.WriteLine("Contains 5? " + numbers.Contains(5)); // not a lambda here!

Console.WriteLine("Number of odd elements: " + numbers.Count(x => x % 2 == 1));
Console.WriteLine("Total no. of elements: " + numbers.Count()); // beware!