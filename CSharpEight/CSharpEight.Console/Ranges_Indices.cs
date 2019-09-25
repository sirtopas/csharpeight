using System;

namespace CSharpEight.Console
{
    public class Ranges_Indices
    {
        public string Indices()
        {
            Index index1 = 3;  // number 3 from beginning
            Index index2 = ^4; // number 4 from end 
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            System.Console.WriteLine($"{a[index1]}, {a[index2]}"); // "3, 6"
            System.Console.WriteLine($"{a[(Index)3]}, {a[^4]}"); // "3, 6"

            return $"{a[index1]}, {a[index2]}";
        }
    }
}