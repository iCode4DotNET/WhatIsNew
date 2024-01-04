
#region [ The global using directive ]

global using System.Security.Cryptography.X509Certificates;

#endregion

using Part10.Classes;
using System.ComponentModel;

#region [ Nondestructive mutation for anonymous types ]

//C# 9 introduced the with keyword, to perform nondestructive mutation on
//records. In C# 10, the with keyword also works with anonymous types:

var a1 = new { A = 1, B = 2, C = 3, D = 4, E = 5 };
var a2 = a1 with { E = 10 };

Console.WriteLine(a1);
Console.WriteLine(a2);

Console.ReadKey();  

#endregion


#region [ New deconstruction syntax ]

//C# 7 introduced the deconstruction syntax for tuples (or any type with a
//Deconstruct method).

//C# 10 takes this syntax further, letting you mix
//assignment and declaration in the same deconstruction

var point = (3, 4);
double x = 0;
(x, double y) = point;

Console.WriteLine(x);
Console.WriteLine(y);

#endregion


#region [ Lambda expression enhancements ]

//The syntax around lambda expressions has been enhanced in a number of ways.


// First, implicit typing (var) is permitted:

var greeter = () => "Hello, world";

//The implicit type for a lambda expression is an Action or Func delegate,
//so greeter, in this case, is of type Func<string>

Func<string> greeter2 = () => "Hello, world";


//You must explicitly state any parameter types:

var square = (int x) => x * x;

Func<int, int> square2 = (int x) => x * x;


//Second, a lambda expression can specify a return type:

var sqr = int (int x) => x;

Func<int, int> sqr2 = int (int x) => x;


//This is primarily to improve compiler performance with complex nested lambdas.

//Third, you can pass a lambda expression into a method parameter of type
//object, Delegate, or Expression:

Test2.M1(() => "test1"); // Implicitly typed to Func<string>
Test2.M2(() => "test2"); // Implicitly typed to Func<string>
Test2.M3(() => "test3"); // Implicitly typed to Expression < Func<string> >

//Finally, you can apply attributes to a lambda expression’s compile-generated
//target method (as well as its parameters and return value):

Action a = [Description("test")] () => { };
#endregion


#region [ Nested property patterns ]

var obj = new Uri("https://www.icode4.net");

Console.WriteLine($"Scheme = {obj.Scheme}");                //Scheme = https
Console.WriteLine($"Host = {obj.Host}");                    //Host = www.icode4.net
Console.WriteLine($"Port = {obj.Port}");                    //Port = 443
Console.WriteLine($"AbsolutePath = {obj.AbsolutePath}");    //AbsolutePath = /
Console.WriteLine($"AbsoluteUri = {obj.AbsoluteUri}");      //AbsoluteUri = https://www.icode4.net/


if (obj.Scheme.Length == 5) { }

if (obj is Uri { Scheme: { Length: 5 } }) { }

if (obj is Uri { Scheme.Length: 5 }) { }


#region [ آنچه در سی شارپ گذشت ]
// x = i++ ; 
// x = i + 1 ; 

// x = 10 , a = 10 
// x = a++; // x = 10 , a = 11
// x = ++a; // x = 11 , a = 11 
#endregion

#endregion