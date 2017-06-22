using System;

namespace ChangeNumMod3
{
    class ChangeNumMod3Main
    {
        static void Main()
        {
            for (int i = 0; i < 101; i++)
            {
                string str1 = "Tutti";
                string str2 = "Frutti";
                string str = i % 3 == 0 && i % 5 == 0 ? str1 + "-" + str2 : i % 3 == 0 ? str2 : i % 5 == 0 ? str1 :
                             i.ToString();
                Console.WriteLine(str + " ");
            }
            Console.ReadKey();
        }
    }
} 
