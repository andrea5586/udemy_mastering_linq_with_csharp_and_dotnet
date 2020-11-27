<Query Kind="Statements" />

var word1 = "helloooo";
var word2 = "help";

// distinct letters in helloooo
Console.WriteLine(word1.Distinct());

// letters in both word1 and word2
var lettersInBoth = word1.Intersect(word2);
Console.WriteLine(lettersInBoth);

// letters in all words
Console.WriteLine(word1.Union(word2));

// letters in word1, but not in word1
Console.WriteLine(word1.Except(word2));