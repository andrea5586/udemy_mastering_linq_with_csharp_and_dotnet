<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Drawing.dll</Reference>
  <Namespace>System.Drawing</Namespace>
</Query>

var numbers = Enumerable.Range(1,10);
Console.WriteLine("We have " + numbers.Count() + " elements");
//Console.WriteLine(numbers);

// 1 2 3 4 5 ...

// 1 2 -> 3
// 3 3 -> 6

Console.WriteLine("Sum = " +
	numbers.Sum());
	
// 1 1 -> 1
// 1 2 -> 2
// 2 3 -> 6
	
Console.WriteLine("Average = " +
	numbers.Average());
	
var words = new[] { "one", "two", "three" };
Console.WriteLine(words.Aggregate("hello", (p,x) => p + "," + x));

// Rectangle.Union(r1, r2)

var rectangles = new[] {
  new Rectangle(0,0,20,20),
  new Rectangle(20,20,60,60),
  new Rectangle(80,80,20,20)
};
Console.WriteLine(rectangles.Aggregate(Rectangle.Union));