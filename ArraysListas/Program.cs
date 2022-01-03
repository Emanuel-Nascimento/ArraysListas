using System;

namespace ArraysListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            // Exemplo
            var numbers = new int [] { 1, 2, 3 };
            var numberCopy = new int[3];
            // 0-based
            for(var i = 0; i < numbers.Length; i++)
            {
                numberCopy[i] = numbers[i];
            }

            var numbersString = "0 1 2 3";
            var numbersArray = numbersString.Split(' ');
            var numbersConvertedFromString = Array.ConvertAll(numbersArray, Convert.ToInt32);
        }
    }
}
