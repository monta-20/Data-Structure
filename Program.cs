//BitArray
/*
A collection of bits (0 or 1 / true or false).

Belongs to System.Collections.

Internally, it stores bits efficiently instead of using a full bool[] array.

Mutable → you can set, clear, or toggle bits.

Supports bitwise operations like AND, OR, XOR, NOT.
*/
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        BitArray bitArray = new BitArray(8); // 8 bits initialized to false (0)
        BitArray bitArray1 = new BitArray(8, true); // 8 bits initialized to true (1)
        bool[] flags = { true, false, true }; // From bool array
        BitArray bits1 = new BitArray(flags);
        // From int array (each int = 32 bits)
        int[] numbers = { 1, 2 };
        BitArray bits2 = new BitArray(numbers); // 64 bits: 00000001 00000010

        bits1[0] = true;   // set first bit
        bool firstBit = bits1[0]; // read first bit

        // Iterating
        for (int i = 0; i < bits1.Count; i++)
        {
            Console.WriteLine(bits1[i]);
        }
    }
}
