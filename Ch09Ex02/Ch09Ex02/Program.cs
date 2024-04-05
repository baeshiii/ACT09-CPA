using System;

namespace Ch09Ex02
{
    class Program
    {
        static int MaxValue(int[] intArray)
        {
            int maxVal = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                    maxVal = intArray[i];
            }
            return maxVal;
        }

        static double MaxValue(double[] doubleArray)
        {
            double maxVal = doubleArray[0];
            for (int i = 1; i < doubleArray.Length; i++)
            {
                if (doubleArray[i] > maxVal)
                    maxVal = doubleArray[i];
            }
            return maxVal;
        }

        static void Main(string[] args)
        {
            int[] myIntArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxIntVal = MaxValue(myIntArray);
            Console.WriteLine("The maximum value in myIntArray of type integer is " + maxIntVal);

            double[] myDblArray = { 5, 1, 2, 7, 3, 6, 4, 0, 8, 0 };
            double maxDblVal = MaxValue(myDblArray);
            Console.WriteLine("\nThe maximum value in myDblArray of type double is " + maxDblVal);

            Console.ReadKey();
        }
    }
}
