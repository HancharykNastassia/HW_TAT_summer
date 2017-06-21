using System;

namespace ChangeNumMod3
{
    class ChangeNumMod3Main
    {
        static void Main()
        {
            for (int i = 0; i < 101; i++)
            {
                string str = i % 3 == 0 ? "3*" + (i / 3).ToString() : i.ToString();
                Console.Write(str + " ");
            }
            Console.ReadKey();
        }
    }
} 
