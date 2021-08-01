using System;
using System.Linq;
using System.Text;

namespace ZigZagString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int lines = int.Parse(Console.ReadLine());

            // Generates array with the same len as str. Every number shows the line for every char in str.  
            int[] indexes = GenerateArray(str.Length, lines);
            
            Console.WriteLine(ConvertText(str,lines, indexes));
        }  

        // For every line, finds all chars that should be in it.
        public static string ConvertText(string str, int lines, int[] indexes)
        {
            StringBuilder sb = new StringBuilder();
                                                               

            for(int line=0;line<lines;line++)
            {                
                for(int index=0; index<indexes.Length;index++)
                {
                    if (line == indexes[index])
                    {
                        sb.Append(str[index]);
                    }
                }
            }
            return sb.ToString();
        }
        static int[] GenerateArray(int len, int lines)
        {
            int[] arr = new int[len];
            int value = 0;
            bool countUp = true;

            for (int i = 0; i < len; i++)
            {
                if (value >= lines)
                {
                    countUp = false;
                    value = lines - 2;


                }
                else if (value < 0)
                {
                    countUp = true;
                   value = 1;
                }

                arr[i] = value;

                if (countUp)
                {
                    value++;
                }
                else
                {
                    value--;
                }

                

            }

            return arr;
        }
    }
}
