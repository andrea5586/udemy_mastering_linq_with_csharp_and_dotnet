<Query Kind="Statements" />

var list = new ArrayList();
list.Add(1);
list.Add(2);
list.Add(3);
// this won't work
//Console.WriteLine(list.Select(i => (int)i).Sum());
Console.WriteLine(list.Cast<int>().Sum());

// cast not valid
//Console.WriteLine(list.Cast<float>().Average());

// materializing collections
var numbers = Enumerable.Range(1,10);
var arr = numbers.ToArray(); // ToList()
var dict = numbers.ToDictionary(i => (double)i/10, i => i%2 == 0);
Console.WriteLine(dict);
// materializing an infinite sequence is a bad idea

//
var arr2 = new[]{1,2,3};
var arre = arr2.AsEnumerable(); // simply casts to IEnumerable<int>
ParallelQuery<int> pq = arr2.AsParallel();
// AsQueryable()