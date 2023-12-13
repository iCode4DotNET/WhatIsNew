namespace Part12.Classes;

internal class Test
{

    /// <summary>
    /// Block Body
    /// </summary>
    internal static int GetSum(List<int> numbers)
    {
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        return sum;
    }

    /// <summary>
    /// Expression Body
    /// </summary>
    internal static int GetSum2(List<int> numbers) => numbers.Sum();

}


#region [ New Ctor Style ]
/// <summary>
/// Include a parameter list directly after a class (or struct) declaration
/// </summary>
/// <param name="firstName">نام</param>
/// <param name="lastName">نام خانوادگی</param>
internal class Person(string firstName, string lastName)
{
    public void Print() => Console.WriteLine(firstName + " " + lastName);
} 
#endregion
