using Part08.Classes;
using System;
using System.IO;

namespace Part08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region [ Indices and ranges ]
          
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            char lastElement = vowels[^1]; // 'u'
            char secondToLast = vowels[^2]; // 'o'
                                            //Ranges let you “slice” an array by using the.. operator:
            char[] firstTwo = vowels[..2]; // 'a', 'e'
            char[] lastThree = vowels[2..]; // 'i', 'o', 'u'
            char[] middleOne = vowels[2..3]; // 'i'
            char[] lastTwo = vowels[^2..]; // 'o', 'u'


            Index last = ^1;
            Range firstTwoRange = 0..2;
            firstTwo = vowels[firstTwoRange]; // 'a', 'e 

            #endregion

            #region [ Null - coalescing assignment ]
            
            //The ??= operator assigns a variable only if it’s null

            var s = "";
            if (s == null)
                s = "Hello, world";
            s ??= "Hello, world";
            #endregion

            #region [ Using declarations ]
           
            //If you omit the brackets and statement block following a using statement, it
            //becomes a using declaration.
            //The resource is then disposed when execution falls outside the enclosing statement block:

            if (File.Exists("file.txt"))
            {
                using (var reader = File.OpenText("file.txt"))
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }

            if (File.Exists("file.txt"))
            {
                using var reader = File.OpenText("file.txt");
                Console.WriteLine(reader.ReadLine());
            }
            #endregion

            #region [ Default interface members ]
            
            var log1 = (ILogger)new MyLog();
            log1.Log("hello");

            var log2 = (ILogger)new MyLog();
            log1.Log2("hello");

            var log3 = (ILogger)new MyLog2();
            log3.Log2("hello");

            #endregion

            #region [ Switch expressions ]
           
            var title = "";
            var code = 123;
            switch (code)
            {
                case 111:
                    title = "a111";
                    break;

                default:
                    title = "DEFAULT";
                    break;
            }


            code = 123;
            title = code switch
            {
                111 => "a111",
                _ => "DEFAULT",
            };

            Console.WriteLine(title);
            #endregion
    
            #region [ Tuple, positional, and property patterns ]
          
            // C# 8 supports three new patterns, mostly for the benefit of switch statements / expressions.
            //Tuple patterns let you switch on multiple values

            int cardNumber = 12;
            string suite = "spades";
            string cardName = (cardNumber, suite) switch
            {
                (13, "spades") => "King of spades",
                (13, "clubs") => "King of clubs",
                _ => "Nothing of Nothing",
            };

            Console.WriteLine(cardName);

            #endregion
     
            #region [ Positional patterns ]
           
            //Positional patterns allow a similar syntax for objects that expose a
            //deconstructor, and property patterns let you match on an object’s properties.

            //You can use all of the patterns both in switches and with the is operator.

            //The following example uses a property pattern to test whether obj is a string with a length of 4:

            var obj = "1234";
            if (obj is string { Length: 4 })
            {

            }

            #endregion

            #region [ Nullable reference types ]

            //Whereas nullable value types bring nullability to value types, nullable
            //reference types do the opposite and bring(a degree of) non - nullability to
            //reference types, with the purpose of helping to avoid NullReferenceExceptions

           #nullable enable // Enable nullable reference types from this point on

            string s1 = null; // Generates a compiler warning! (s1 is nonnullable)
            string? s2 = null; // OK: s2 is nullable reference type

            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2?.ToString()); 
            
            #endregion

        }
    }
}
