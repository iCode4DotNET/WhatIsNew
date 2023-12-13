using Part07.Classes;
using System;

namespace Part07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [ Numeric literal improvements ]

            //Numeric literals in C# 7 can include underscores to improve readability.
            //These are called digit separators and are ignored by the compiler:

            int million = 1_000_000;
            Console.WriteLine(million);

            // Binary literals can be specified with the 0b prefix:
            var bin = 0b0000_1111;
            Console.WriteLine(bin);
            #endregion

            #region [ Type patterns and pattern variables ]

            //You can also introduce variables on the fly with the is operator.
            //These are called pattern variables

            object myObjVarible = "Hello";
            if (myObjVarible is string s)
                Console.WriteLine(s.Length);

            #endregion

            #region [ The switch statement also supports type patterns ]
            //so you can switch on type as well as constants
            //You can specify conditions with a when clause and also switch on the null value:

            switch (myObjVarible)
            {
                case int i:
                    Console.WriteLine($"{i} It's an int!");
                    break;
                case string str:
                    Console.WriteLine(str.Length);
                    break;
                case bool b when b == true:
                    Console.WriteLine("True");
                    break;
                case null:
                    Console.WriteLine("Nothing");
                    break;
            }
            #endregion

            #region [ Local methods ]
            Test.WriteCubes();
            #endregion

            #region [ Deconstruction ]
            var person = new Person2("Soroush Sadr");
            var (first, last) = person;
            Console.WriteLine(first);
            Console.WriteLine(last);
            #endregion

            #region [ Tuples ]

            //Perhaps the most notable improvement to C# 7 is explicit tuple support.
            //Tuples provide a simple way to store a set of related values:

            var tuple = ("Soroush", 39);
            Console.WriteLine(tuple.Item1); // Soroush
            Console.WriteLine(tuple.Item2); // 39


            var tuple2 = (name: "Soroush", age: 39);
            Console.WriteLine(tuple2.name); // Soroush
            Console.WriteLine(tuple2.age); // 39

            //Tuples implicitly support the deconstruction pattern,
            //so you can easily deconstruct them into individual variables

            var (name, age) = ("Soroush", 39);
            Console.WriteLine(name); // Soroush
            Console.WriteLine(age); // 39


            //C# 7.1 also relaxed the rules for switch statements
            //(so that you can patternmatch on generic type parameters),
            //allowed a program’s Main method to be asynchronous,
            //allowed tuple element names to be inferred

            var now = DateTime.Now;

            var tuple3 = (now.Hour, now.Minute, now.Second);
            Console.WriteLine($"{tuple3.Hour} : {tuple3.Minute} : {tuple3.Second}");

            var (Hour, Minute, Second) = (now.Hour, now.Minute, now.Second);
            Console.WriteLine($"{Hour} : {Minute} : {Second}");

            #endregion

            #region [ Default keyword ]
            //From C# 7.1, you can omit the type when using the default keyword, if
            //the type can be inferred

            decimal number = 0; // int
            decimal number2 = 0M; // decimal
            decimal number3 = default; // decimal

            Console.WriteLine($"{number}{number2}{number3}"); 
            #endregion
            
            Console.ReadKey();
        }
    }
}