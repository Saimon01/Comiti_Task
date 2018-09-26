using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppComitoTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Write();
            Console.Write("Ciao");
            Task t = new Task(Write);
            t.Start();
            int i = 100;
            while (i > 0)
            {
                Console.Write("Hello");
                i = i + 1;
            }
            Console.WriteLine();
        }
        public static void Write()
        {
            int i = 10;
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
}
