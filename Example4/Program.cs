// See https://aka.ms/new-console-template for more information

// Arrays are fixed size


var nums = new int[5] { 1, 1, 1, 1, 1 };

// It is mandatory to specify the size of the array when it is created
// and all the elements must be of the same type
// The size of the array cannot be changed once it is created
// All elements have to be initialized
var numbs = new int[5] { 1, 2, 3, 4, 0 };

foreach (var num in numbs)
{
    Console.WriteLine(num);
}

// Regtangular matrix
var matrix = new int[3, 3]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
};
var matrix2 = new int[3][5];

var jaggedArray = new int[3][]
{
    new int[3] { 1, 2, 3 },
    new int[4] { 4, 5, 6, 7 },
    new int[2] { 8, 9 },
};

var jaggedArray2 = new int[3][];
jaggedArray2[0] = new int[3] { 1, 2, 3 };
jaggedArray2[1] = new int[4] { 4, 5, 6, 7 };
jaggedArray2[2] = new int[2] { 8, 9 };

// Lists are dynamic size
var list = new List<int> { 1, 2, 3, 4, 5 };
list.Add(6);
list.AddRange(new int[] { 7, 8, 9 });
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}
