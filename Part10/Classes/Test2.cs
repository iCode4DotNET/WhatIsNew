using System.Linq.Expressions;

namespace Part10.Classes;

internal class Test2
{
    public Test2()
    {
        //The global using directive
        X509Certificate2 x509 = new X509Certificate2();
    }


    #region [ Pass a lambda expression into a method parameter ]
    internal static void M1(object x) { }
    internal static void M2(Delegate x) { }
    internal static void M3(Expression x) { } 
    #endregion
}