using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class A { public void mult(ref int a) { a *= 2; } }
    class B { public int mult(ref int b) { b *= 3; return b; } }
    class c { public void mult(ref int c) { c *= 5; } }
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            int div, c1 = 0, c2 = 0, c3 = 0, initial = 1;
            A classA = new A();
            B classB = new B();
            c classC = new c();
            Console.WriteLine("Enter New Value");
            var newvalue = int.Parse(Console.ReadLine());
            var temp = newvalue;
            while (true)
            {
                if (temp % 2 == 0)
                {
                    temp = temp / 2;
                    classA.mult(ref initial);
                    c1++;
                    //Console.WriteLine(div);
                }
                else if (temp % 3 == 0)
                {
                    temp = temp / 3;
                    classB.mult(ref initial);
                    c2++;
                    //Console.WriteLine(div);
                }
                else if (temp % 5 == 0)
                {
                    temp = temp / 5;
                    classC.mult(ref initial);
                    c3++;
                    //Console.WriteLine(div);

                }
                else
                {
                    Console.WriteLine("Wrong input");
                    break;
                }
                if (initial == newvalue)
                {
                    Console.WriteLine(c1);
                    Console.WriteLine(c2);
                    Console.WriteLine(c3);
                    break;
                }
            }

            Console.Read();
        }
    }

}

