using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LREv1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Cümleyi Girin :");
            String metin = Console.ReadLine();
            metin = metin.ToUpper();
            String karakterler = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ.?,;";
            int[] count = new int[karakterler.Length];
            for (int i = 0; i < metin.Length; i++)
            {
                int index = karakterler.IndexOf(metin[i]);
                if (index < 0)
                    continue;
                else
                {
                    count[index]++;
                }
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] < 1)
                    continue;
                else
                {
                    Console.Write(count[i]+""+karakterler[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
