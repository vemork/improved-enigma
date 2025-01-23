class ReferenceValueTypes
{
    public static void Run()
    {
        Console.WriteLine("ReferenceValueTypes");

        // value types structures and primitives
        // int, float, bool, char, etc
        // Allocated on the stack
        // stored directly in memory
        // removed when out of scope

        // reference types classes and objects like strings/arrays
        // Allocated manually
        // stored in the heap
        // removed by the garbage collector
        // reference types are nullable by default

        var a = 10;
        var b = a; // copy of a
        b++;
        Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); // a: 10, b: 11

        var array1 = new int[3] { 1, 2, 3 };
        var array2 = array1;
        array2[0] = 0;
        // array1 and array2 are references to the same object in memory
        // so changing the value of array2 also changes the value of array1
        Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0])); // array1[0]: 0, array2[0]: 0
    }
}
