//File - scoped namespaces
namespace Part10.Classes;

internal class Test1
{
    public Test1()
    {
        //The global using directive
        X509Certificate2 x509 = new X509Certificate2();
    }
}

internal class Test10
{
    public Test10()
    {
        //The global using directive
        X509Certificate2 x509 = new X509Certificate2();
    }
}