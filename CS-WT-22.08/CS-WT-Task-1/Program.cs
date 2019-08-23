using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WT_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ededler toplusu daxil edin (aralarinda bosluq olmaqla)");
            string StrArray =  Console.ReadLine();
            ArrayMetods arrayMetods = new ArrayMetods(StrArray);

            // arrayin icindeki elementleri int -e cevirmek
            List<int> intList = new List<int>();
            for (int i = 0; i < arrayMetods.arr.Length;i++)
            {
                int item = int.Parse(arrayMetods.arr[i]);
                intList.Add(item);
            }
            // Ededlerin en boyuyun ekarna cixarmaq
            Console.WriteLine($"Daxil edilen ededlerin en boyuyu : {intList.Max()}");

            // Ededlerden en kiciyin ekarna cixarmaq
            Console.WriteLine($"Daxil edilen ededlerin en kiciyi : {intList.Min()}");

            // Ededler cemini tapmaq
            int result = 0;
            foreach (int i in intList)
            {
                result += i;
            }
            Console.WriteLine($"Daxil edilen ededlerin cemi : {result}");

            // Array-dakı elementlərinin yerini əksinə çevirmək
            

            intList.Reverse();
            Console.Write("Daxil edilen ededlerin eksi :");
            foreach (int i in intList)
            {
                Console.Write($" {i}");
            }

            Console.WriteLine(" ");
        }
    }
}
