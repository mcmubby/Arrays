using System;
using System.Linq;

namespace arrayDayTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // string [] students = {"elijah", "bryan", "micheal", "matt", "muiz"};

            // // Console.WriteLine(Array.FindIndex(students, 0, 4, (e => e.Contains("bry"))));

            // int [] strangeNumbers = {89, 34, 79, 5, 10, 43};

            // // Array.Sort(strangeNumbers);
            // // Array.Reverse(strangeNumbers);
            // // foreach (var i in strangeNumbers)
            // // {
            // //     Console.WriteLine(i);
            // // }

            // Array.Clear(strangeNumbers,0,2);
            // Console.WriteLine(strangeNumbers[0]+" "+" "+strangeNumbers[1]+" "+strangeNumbers[2]);

            int [] givenArray = {23,47,89,64,102,90,2,5,10};
            Array.Reverse(givenArray);
            int arraySum = 0;
            foreach (var i in givenArray)
            {
                arraySum+=i;
            }
            Console.WriteLine(arraySum);
            Console.WriteLine(givenArray.Sum());

        }
    }
}
