<Query Kind="Statements">
  <Namespace>System.Collections</Namespace>
</Query>

var arr1 = new[]{1,2,3};
var arr2 = new[]{1,2,3};

Console.WriteLine(arr1 == arr2);
Console.WriteLine(arr1.Equals(arr2));

// LINQ
Console.WriteLine(arr1.SequenceEqual(arr2));

var list1 = new List<int>{1,2,3};
Console.WriteLine(arr1.SequenceEqual(list1));
