using System;

namespace Part08.Classes
{
   
    #region [ Read - only members ]
  
    //C# 8 lets you apply the readonly modifier to a struct’s functions, ensuring
    //that if the function attempts to modify any field,
    //a compile - time error is generated:

    // If a readonly function calls a non-readonly function, the compiler
    //generates a warning(and defensively copies the struct to avoid the possibility of a mutation).

    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public readonly void DontTouch()
        {
            //X = 0; // Error!
        }

        public void ItsOK()
        {
            X = 0;
        }
    }

    #endregion

    #region [ Default interface members ]
    interface ILogger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }

        public static string Prefix = "Default Prefix : ";
        public void Log2(string text)
        {
            Console.WriteLine(Prefix + text);
        }
    }

    class MyLog : ILogger
    {
        void ILogger.Log(string text)
        {
            Console.WriteLine("Inside My Log : " + text);
        }
    }

    class MyLog2 : ILogger
    {
        public MyLog2()
        {
            ILogger.Prefix = "My Log 2 Prefix : ";
        }
    } 
    #endregion
}
