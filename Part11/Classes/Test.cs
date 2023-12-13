using System.Numerics;

namespace Part11.Classes;

#region [ Required members ]

internal class Person
{
    public required string FirstName;
    public required string LastName;
}
#endregion


#region [ INumber<T> ]

/// <summary>
/// Generic math
/// The System.Numerics.INumber<TSelf> interface (new to.NET 7)
/// unifies arithmetic operations across all numeric types, allowing generic
/// methods such as the following to be written:
/// </summary>
internal class MathOperation
{
    internal static T Sum<T>(params T[] numbers) where T : INumber<T>
    {
        T total = T.Zero;
        foreach (T n in numbers)
            total += n; // Invokes addition operator for any numeric type
        return total;
    }
} 
#endregion
