<Query Kind="Program" />

void Main()
{
	var people = new List<Person>{
		new Person { Name = "Adam", Age = 20 },
		new Person{ Name = "Adam", Age = 36 },
	  new Person { Name = "Boris", Age = 18 },
	  new Person { Name = "Claire", Age = 36 },
	  new Person { Name = "Adam", Age = 20 }, // dup
	  new Person { Name = "Jack", Age = 20 }
	};
	
	IEnumerable<IGrouping<string, Person>> byName = people.GroupBy(p => p.Name);
	//Console.WriteLine(byName);
	
	// IEnumerable<IGrouping<bool, Person>>
	Console.WriteLine(people.GroupBy(p => p.Age < 30));
	
	// same, but we only keep the values instead of
	// entire objects
	var byAgeNames = people.GroupBy(p => p.Age, p => p.Name);
	//Console.WriteLine(byAgeNames);
	
	foreach (var item in byAgeNames)
	{
	  Console.WriteLine($"These people are {item.Key} years old");
	  foreach (var name in item)
	    Console.WriteLine($" - {name}");
	}
}

class Person
{
  public string Name;
  public int Age;
}