// A set of name/value pairs (constants)
// that can be used to define a specific type of data
// for example relate constants

// const int RegularAirMail = 1;
// const int RegisteredAirMail = 2;
// const int Express = 3;

public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3,
}

class ProgramEnum
{
    static void Main()
    {
        var method = ShippingMethod.RegisteredAirMail;
        Console.WriteLine((int)method);

        var methodId = 2;
        Console.WriteLine((ShippingMethod)methodId);

        Console.WriteLine(method.ToString()); // explicit conversion
        Console.WriteLine(method);

        var NewShippingMethod = Enum.Parse(typeof(ShippingMethod), "Express");
        Console.WriteLine((ShippingMethod)NewShippingMethod);
    }
}

