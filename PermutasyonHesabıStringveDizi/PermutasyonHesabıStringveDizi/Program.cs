using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            permute("ydyd",0,3);
            permuteDigits(new int[]{1,2,3,4,5,6},0,5);
            Console.ReadKey();
        }
        public static void permuteDigits(int[] array, int l, int r)
        {
            if (r == l)
            {
                Console.WriteLine(array[0] + "" + array[1] + "" + array[2] + "" + array[3] + array[4] + "" + array[5]);
            }
            else
            {
                for (int i = l; i <=r; i++)
                {
                    array = swap2(array,l,i);
                    permuteDigits(array,l+1,r);
                    array = swap2(array,l,i);
                }
            }
        }
        public static int[] swap2(int []arr,int i,int j)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
            return arr;

        }
        public static void permute(String str,int l,int r)
        {
            if (r==l)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = l  ; i <= r; i++)
                {
                    str = swap(str,l,i);
                    permute(str,l+1,r);
                    str = swap(str, l, i);
                }
            }
        }
        public static String swap(String a, int i, int j)
        {
            Char[] arry = a.ToCharArray();
            char temp=a[i];
            arry[i]=arry[j];
            arry[j] = temp;
            return new String(arry);
        }
    }
}
