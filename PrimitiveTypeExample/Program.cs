using System;
namespace PrimitiveTypeExample
{
    class PrimitiveDataExample
    {
        static void Main()
        {
            /*sbyte a = sbyte.MaxValue;
            sbyte b = 100;
            sbyte c = default(sbyte);

            byte d = byte.MaxValue;
            short e = short.MaxValue;
            ushort f = ushort.MaxValue;
            int g = int.MaxValue;
            uint h = uint.MaxValue;
            long i = long.MaxValue;
            ulong j = ulong.MaxValue;
            float k = float.MaxValue;
            double l = double.MaxValue;
            decimal m = decimal.MaxValue;
            char n = 'A';
            string o = "abc";
            bool p = true;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine(o);
            Console.WriteLine(p);

            System.Console.ReadKey();*/


            //Arithmetic Operators

            decimal a = 10M;
            decimal b = 3M;

            decimal c = a + b; //Output 13
            decimal d = a - b; //Output 7
            decimal e = a * b; //Output 30
            decimal f = a / b; //Output 3.3333333
            decimal g = a % b;  //Output: 1

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);

            Console.WriteLine();

            //Assignment Operator
            a += 20M;
            Console.WriteLine(a); //30

            a -= 20M;
            Console.WriteLine(a); //10

            a *= 3M;
            Console.WriteLine(a); //30

            a /= 3M;
            Console.WriteLine(a); //10

            a %= 3M;
            Console.WriteLine(a); //1


            //Increment / Decrement Operator
            a = 10M;
            Console.WriteLine();
            Console.WriteLine(++a); //11
            Console.WriteLine(a++);//11
            Console.WriteLine(a); //12
            Console.WriteLine(--a); //11
            Console.WriteLine(a--); //11
            Console.WriteLine(a); //10
            Console.WriteLine();

            //Comparison Operator
            bool b1 = a == 10;
            Console.WriteLine(b1); //true
            bool b2 = a != 10;
            Console.WriteLine(b2); //false
            bool b3  = a > 10;
            Console.WriteLine(b3); //false
            bool b4 = a < 10;
            Console.WriteLine(b4); //false
            bool b5 = a <= 10;
            Console.WriteLine(b5); //true
            bool b6 = a >= 10;
            Console.WriteLine(b6); //true
            Console.WriteLine();

            //Logical Operators

            bool b7 = a == 10 & b == 10; //false
            Console.WriteLine(b7);
            bool b8 = a == 10 && b == 10; //false
            Console.WriteLine(b8);
            bool b9 = a == 10 | b == 10; //true
            Console.WriteLine(b9);
            bool b10 = a == 10 || b == 10; //true
            Console.WriteLine(b10);
            bool b11 =!(a==10); 
            Console.WriteLine(b11); //false
            bool b12 = a == 10 ^ b == 10;
            Console.WriteLine(b12); //true

            //concatenation operator
            string name = "Seun";
            int age = 20;
            string message = "Hey, " + name + " your " + "age " + "is " + age + ".";
            Console.WriteLine(message);

            //tenary operator

            string title = (age < 13) ? "Child" : (age <= 13 && age <= 19) ? "Teenager" : "Adult";
            Console.WriteLine(title); //Adult

            //operator precedence
            double z = 10 + 4 * 30 / 10;
            Console.WriteLine(z); //22
            Console.ReadKey();

        }
    }
}
