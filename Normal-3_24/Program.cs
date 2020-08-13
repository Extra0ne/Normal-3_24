using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normal_3_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string sentence = Console.ReadLine();
            string[] str = sentence.Split(' ');
            int maxWord = 0;
            int indexMax = 0;
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i].Length > maxWord)
                {
                    maxWord = str[i].Length;
                    indexMax = i;
                }  

            }

            Console.Write("Самое длинное слово: {0}\n", str[indexMax]);
            Console.ReadLine();
        }
    }
}
