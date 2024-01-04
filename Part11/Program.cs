using Part11.Classes;

#region [ Raw string literals ]

//Wrapping a string in three or more quote characters creates a raw string
//literal, which can contain almost any character sequence without escaping or
//doubling up. This makes it easy to represent JSON, XML, and HTML
//literals, as well as regular expressions and source code:

//string raw0 = "<file path="c:\temp\test.txt"></file>";
string raw01 = "<file path=\"c:\temp\test.txt\"></file>";

string raw = """<file path="c:\temp\test.txt"></file>""";


Console.WriteLine("ali\reza\tina\nima");
Console.Write("123456789\reza");

Console.ReadKey();

Console.WriteLine(raw); // <file path="c:\temp\test.txt"></file>


string multiLineRaw = $"""
Line 1
Line 2
The date and time is {DateTime.Now}
""";

Console.WriteLine(multiLineRaw);

var str = $$"""{ "TimeStamp": "{{DateTime.Now}}" }""";
Console.WriteLine(str); //{ "TimeStamp": "12/13/2023 4:29:18 AM" }

#endregion


#region [ List patterns ]

//List patterns match a series of elements in square brackets, and work with
//any collection type that is countable (with a Count or Length property)
//and indexable (with an indexer of type int or System.Index)

int[] numbers = { 0, 1, 2, 3, 4 };
Console.WriteLine(numbers is [0, 1, 2, 3, 4]); // true
Console.WriteLine(numbers is [_, 1, .., 4]);   // true
Console.WriteLine(numbers is [0, .., 4]);      // true
Console.WriteLine(numbers is [0, .., 3]);      // false 
#endregion


#region [ Required members ]

//Person person = new Person();
// Required member 'Person.FirstName' must be set in the object initializer or attribute constructor.	

var person = new Person 
{
    FirstName = "Soroush", 
    LastName = "Sadr" 
};

#endregion


#region [ INumber<T> ]

int intSum = MathOperation.Sum(3, 5, 7);
double doubleSum = MathOperation.Sum(3.2, 5.3, 7.1);
decimal decimalSum = MathOperation.Sum(3.2m, 5.3m, 7.2m);

Console.WriteLine(intSum);
Console.WriteLine(doubleSum);
Console.WriteLine(decimalSum);

#endregion