namespace Part09.Classes
{
    #region [ Init-only setters ]
    internal class Person
    {
        /// <summary>
        /// Init-only setters
        /// </summary>
        public int ID { get; init; }

        public Person()
        {
            ID = 1234;
        }

        //This makes it possible to create immutable (read-only) types that can be
        //populated via an object initializer instead of a constructor, and helps to avoid
        //the anti-pattern of constructors that accept a large number of optional
        //parameters.Init-only setters also allow for nondestructive mutation when
        //used in records.
    }
    #endregion


    #region [ Record ]
    //A record is a special kind of class that’s
    //designed to work well with immutable data.
    //Its most special feature is that it
    //supports nondestructive mutation via a new keyword(with)

    internal record Point
    {
        // Expression Body
        public Point(double x, double y) => (X, Y) = (x, y);

        // Block Body
        //public Point(double x, double y)
        //{
        //    (X, Y) = (x, y);
        //}

        public double X { get; init; }
        public double Y { get; init; }
    }

    // In simple cases, a record can also eliminate the boilerplate code of defining
    //properties and writing a constructor and deconstructor.We can replace our
    //Point record definition with the following, without loss of functionality:

    internal record Point2(double X, double Y);

    //Like tuples, records exhibit structural equality by default. Records can
    //subclass other records, and can include the same constructs that classes can
    //include.The compiler implements records as classes at runtime. 
    #endregion



    internal class Test
    {
        // Pattern-matching improvements

        //string GetWeightCategory(decimal bmi)
        //{
        //    return bmi switch
        //    {
        //        < 18.5m => "underweight",
        //        < 25m => "normal",
        //        < 30m => "overweight",
        //        _ => "obese"
        //    };
        //}

        internal static string GetWeightCategory(decimal bmi) => bmi switch
        {
            < 18.5m => "underweight",
            < 25m => "normal",
            < 30m => "overweight",
            _ => "obese"
        };

        //internal static bool IsVowel(char c)
        //{
        //    return c is 'a' or 'e' or 'i' or 'o' or 'u';
        //}

        internal static bool IsVowel(char c) => c is 'a' or 'e' or 'i' or 'o' or 'u';


        //internal static bool IsLetter(char c)
        //{
        //    return c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');
        //}

        internal static bool IsLetter(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');

    }
}