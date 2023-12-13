

#region [ Top-level statements ]

// With top-level statements , you can
//write a program without the baggage of a Main method and Program class

using Part09.Classes;
using System;

Console.WriteLine("Hello, World!");

#endregion


#region [ Init-only setters ]

//var p1 = new Person();
//p1.ID = 123;

//This behaves like a read-only property, except that it can also be set via an
//object initializer
var person1 = new Person() { ID = 123 };

#endregion


#region [ Record ]
var p1 = new Point(2, 3);
var p2 = p1 with { Y = 4 };

Console.WriteLine(p1);
Console.WriteLine(p2);

var p3 = new Point2(20, 30);
var p4 = p3 with { Y = 40 };

Console.WriteLine(p3);
Console.WriteLine(p4); 
#endregion