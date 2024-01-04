using Part12.Classes;


#region [ Alias ]

//C# has always allowed you to alias a simple or generic type via the using directive
using ListOfInt = System.Collections.Generic.List<int>;

//From C# 12, this approach works with other kinds of types, too, such as arrays and tuples

using NumberList = double[];
using MyPointTuple = (int X, int Y);


var list = new ListOfInt
{
    1,
    2
};

foreach (int item in list)
{

}


NumberList numberList = [2.5, 3.5];

MyPointTuple p = (3, 4);
p.X = 1;
p.Y = 2;

Console.WriteLine(p.X);
Console.WriteLine(p.Y);


#endregion


#region [ Collection expressions ]

char[] vowels0 = new char[] { 'a', 'e', 'i', 'o', 'u' };

char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

char[] vowels2 = ['a', 'e', 'i', 'o', 'u'];

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//List<int> numbers3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> numbers3 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

ListOfInt numbers4 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

#endregion


var sum1 = Test.GetSum(numbers);

//target-typed
var sum2 = Test.GetSum2([1,2,3]);


var person1 = new Person("Soroush", "Sadr");
person1.Print();


#region [ Default lambda parameters ]

//This feature is useful with libraries such as ASP.NET Minimal API.
var print = (string message = "Hello World") => Console.WriteLine(message);
print();
print("Salam"); 

#endregion