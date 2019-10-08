using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
         
        }

        public static void Print_atoiz1()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.WriteLine(c);
            }
        }
        public static bool ISUpper (char c)
        {
            for (int i = 97; i < 127; i++)
            {
                if((int)c > 97 && (int)c < 127)
                {
                    return true;
                }
            }
                return false;
        }
        
        public static bool ISLower (char c)
        {
            for (int i = 65; i < 90; i++)
            {
                if ((int)c > 97 && (int)c < 127)
                {
                    return true;
                }
            }
            return false;
        }

        public static char ToUpper(char c)
        {
            return c;
        }
    }
}
