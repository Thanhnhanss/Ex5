using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            char[,] arr = new char[n * 2,n * 2];
            ClearArray(arr, n);
            DrawnN(arr,n);
            PrintArray(arr, n);
            
        }
        public static void ClearArray( char[,] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for ( int j = 0; j < n; j++)
                {
                    arr[i, j] = ' ';
                }
            }
        }
        public static void PrintArray(char[,]arr, int n)
        {
            for(int i=0; i < n; i++)
            {
                for(int j=0; j < n; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void DrawnN(char[,]arr,int n)
        {
            for( int i=0; i < n; i++)
            {
                arr[i, 0] = 'n';
                arr[i,i ] = 'n';
                arr[i, n-1] = 'n';
            }
        }
    }
}
