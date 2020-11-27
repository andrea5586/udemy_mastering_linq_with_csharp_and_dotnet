<Query Kind="Statements" />

// first: returns first element satisfying a predicate or throws
var numbers = new List<int>{1,2,3};
Console.WriteLine(numbers.First());
Console.WriteLine(numbers.First(x => x > 2)); // try 10
Console.WriteLine(numbers.FirstOrDefault(x => x > 10)); // string - null

// same for last value
Console.WriteLine(numbers.Last());
Console.WriteLine(numbers.Last(x => x < 3));

// single: ensures that there's only one value, otherwise throws

// throws because non-singular
//Console.WriteLine(numbers.Single());

// also throws
//Console.WriteLine(numbers.SingleOrDefault());

// doesn't throw only if sequence is empty
Console.WriteLine("Empty array: " + new int[]{}.SingleOrDefault());

Console.WriteLine("Item at position 1: " + numbers.ElementAt(1));
Console.WriteLine("Item at position 4: " + numbers.ElementAtOrDefault(4));