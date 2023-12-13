using System;

namespace Part07.Classes
{
    internal class Test
    {
        #region [ Local methods ]

        //A local method is a method declared within another function
        public static void WriteCubes()
        {
            Console.WriteLine(Cube(3));
            Console.WriteLine(Cube(4));
            Console.WriteLine(Cube2(5));

            // Block Body
            int Cube(int value)
            {
                return value * value * value;
            }

            // Expression Body
            int Cube2(int value) => value * value * value;
        }

        //Local methods are visible only to the containing function and can capture
        //local variables in the same way that lambda expressions do. 
        #endregion
    }

    #region [ More expression-bodied members ]

    //C# 6 introduced the expression-bodied “fat-arrow” syntax for methods, readonly properties, operators, and indexers.
    //C# 7 extends this to constructors, read/write properties, and finalizers:
    public class Person
    {
        public Person(string name) => Name = name;

        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value ?? string.Empty;
        }
        ~Person() => Console.WriteLine("finalize");
    }
    #endregion

    #region [ Deconstructors ]

    //C# 7 introduces the deconstructor pattern
    //Whereas a constructor typically takes a set of values(as parameters)
    //and assigns them to fields,
    //a deconstructor does the reverse and assigns fields back to a set of variables.

    public class Person2
    {
        public Person2(string name) => Name = name;

        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value ?? string.Empty;
        }
        public void Deconstruct(out string firstName, out string lastName)
        {
            int spacePos = Name.IndexOf(' ');
            firstName = Name.Substring(0, spacePos);
            lastName = Name.Substring(spacePos + 1);
        }
    } 
    #endregion
}