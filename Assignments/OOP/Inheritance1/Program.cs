using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class MultiplyClassA {
        public void Mult(ref int a)
        {
            a *= 2;
        }
    }
    class MultiplyClassB {
        public int Mult(ref int b)
        {
            b *= 3;
            return b;
        }
    }
    class MultiplyClassC
    {
        public void Mult(ref int c)
        {
            c *= 5;
        }
    }
    class BaseClass
    {
        static void Main(string[] args)
        {
            int c1 = 0, c2 = 0, c3 = 0, initial = 1;
            MultiplyClassA classA = new MultiplyClassA();
            MultiplyClassB classB = new MultiplyClassB();
            MultiplyClassC classC = new MultiplyClassC();
            Console.WriteLine("Enter New Value");
            var newvalue = int.Parse(Console.ReadLine());
            var temp = newvalue;
            while (true)
            {
                if (temp % 2 == 0)
                {
                    temp = temp / 2;
                    classA.Mult(ref initial);
                    c1++;
                    //Console.WriteLine(div);
                }
                else if (temp % 3 == 0)
                {
                    temp = temp / 3;
                    classB.Mult(ref initial);
                    c2++;
                    //Console.WriteLine(div);
                }
                else if (temp % 5 == 0)
                {
                    temp = temp / 5;
                    classC.Mult(ref initial);
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

