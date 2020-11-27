<Query Kind="Program" />

void Main()
{
	var people = new Person[]
	{
		new Person("Jane", "jane@foo.com"),
		new Person("John", "john@foo.com"),
		new Person("Chris", string.Empty)
	};
	
	var records = new Record[]
	{
		new Record("jane@foo.com", "JaneAtFoo"),
		new Record("jane@foo.com", "JaneAtHome"),
		new Record("john@foo.com", "John1980")
	};
	
	var query = people.Join(records,
		x => x.Email,
		y => y.Mail,
		(person, record) => new { Name = person.Name, SkypeId = record.SkypeId});
	Console.WriteLine(query);
	
	foreach (var item in query)
	{
		Console.WriteLine($"{item.Name} has skype ID {item.SkypeId}");
	}
	
	Console.WriteLine(
	
		people.GroupJoin(
			records,
			x => x.Email,
			y => y.Mail,
			(person, recs) => new {
				Name = person.Name,
				SkypeIds = recs.Select(r => r.SkypeId).ToArray()
			}
		));
}

public class Person
{
	public string Name, Email;
	
	public Person(string name, string email)
	{
		Name = name;
		Email = email;
	}
}

class Record
{
	public string Mail, SkypeId;
	
	public Record(string mail, string skypeId)
	{
		Mail = mail;
		SkypeId = skypeId;
	}
}