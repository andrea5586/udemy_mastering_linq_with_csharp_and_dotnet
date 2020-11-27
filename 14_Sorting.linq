<Query Kind="Program" />

void Main()
{
	var rand = new Random();
	var randomValues = Enumerable.Range(1,10).Select(_ => rand.Next(10) - 5);
	
	var csvString = new Func<IEnumerable<int>,string>(values =>
	{
	  return string.Join(",", values.Select(v => v.ToString()).ToArray());
	});
	
	// different set of values each time
	Console.WriteLine(csvString(randomValues));
	Console.WriteLine(csvString(randomValues.OrderBy(x => x)));
	Console.WriteLine(csvString(randomValues.OrderByDescending(x => x)));
	
	var people = new List<Person>
	{
	  new Person{ Name = "Adam", Age = 36 },
	  new Person { Name = "Boris", Age = 18 },
	  new Person { Name = "Claire", Age = 36 },
	  new Person { Name = "Adam", Age = 20 },
	  new Person { Name = "Jack", Age = 20 }
	};
	
	Console.WriteLine(people);
	Console.WriteLine(people.OrderBy(p => p.Name));
	
	// result is IOrderedEnumerable<Person>
	
	Console.WriteLine(people.OrderBy(p => p.Age)
	                        .ThenByDescending(p => p.Name));
							
	// reverse a string
	string s = "This is a test";
	Console.WriteLine(new string(s.Reverse().ToArray()));
}

// Define other methods and classes here
class Person
{
  public string Name;
  public int Age;
}