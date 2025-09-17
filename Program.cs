// Array
class Program
{
    static void Main(string[] args)
    {
        // Declare an array of integers
        // First method
        //<Data Type>[ ] <Name_Array>
        // Only Declaration of an array doesn’t allocate memory to the array. For that array must be initialized.
        int[] numbers = { 1, 2, 3, 4, 5 };
        // Second method
        // type [ ] < Name_Array > = new < datatype > [size];
        int[] numbers2 = new int[2]; // Declaration and initialization of an array
        numbers2[0] = 10; // Assigning values to the array
        numbers2[1] = 20;
        // Traversing an Array 
        // Using for loop
        for(int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + numbers[i]);
        }
        // Using foreach loop
        foreach (int num in numbers)
        {
            Console.WriteLine("Element: " + num);
        }
        // Updating element
        numbers[0] = 10; // Update the first element
        //Sorting an array
        Array.Sort(numbers); // Sorts the array in ascending order
        Array.Reverse(numbers); // Reverses the array

        // Multidimensional Arrays
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // 2D array
        //updating an element
        matrix[0, 0] = 10; // Update the first element
        for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) returns number of rows or matrix.Length
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) returns number of columns or matrix.Length[0]
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Jagged Arrays
        // A jagged array is an array of arrays.
        // Unlike a 2D rectangular array([,]), each "row" in a jagged array can have a different length.
        // Memory efficiency – if rows don’t need the same size, jagged arrays save memory compared to rectangular arrays.
        int[][] jaggedArray = new int[3][]; // Declare a jagged array with 3 rows
        jaggedArray[0] = new int[] { 1, 2 }; // First row with 2 elements
        jaggedArray[1] = new int[] { 3, 4, 5 }; // Second row with 3 elements
        jaggedArray[2] = new int[] { 6, 7, 8, 9 }; // Third row with 4 elements
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}

//Syntax                                                                       Use Cases                                                                        Example

//<data_type>[] <arr_name> = new <data_type>[size];                      Defining array with size, but not assigns values                           int[] arr1 = new int[5];


//<data_type>[] <arr_name> = new <data_type>[size]{ array_elements};    Defining array with size and assigning the values at the same time         int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };


//<data_type>[] <arr_name> = { array_elements};                         The value of the array is directly initialized without taking its size     int[] intArray3 = { 1, 2, 3, 4, 5};
