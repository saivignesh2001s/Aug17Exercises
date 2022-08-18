namespace aug17product
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int i, j, k;
            Console.WriteLine("Enter the first number");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            k = Convert.ToInt32(Console.ReadLine());
            double product;
            product = i * j * k;
            Console.WriteLine("Product is" + product);
            Console.WriteLine("--Problem--3");
            int p, l;
            Console.WriteLine("Enter the first number");
            p=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            l =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition");
            int m = p + l;
            Console.WriteLine("{0} + {1}={2}",p,l,m);
            Console.WriteLine("Subtraction");
            int a = p - l;
            Console.WriteLine("{0}-{1}={2}",p,l,a);
            Console.WriteLine("Multiplication");
            int u = p * l;
           Console.WriteLine("{0}*{1}={2}",p,l,u);
            Console.WriteLine("division");
            int t = p / l;
            Console.WriteLine("{0}/{1}={2}",p,l,t);
            Console.WriteLine("Remainder");
            int jk = p % l;
            Console.WriteLine("{0} mod {1}={2}",p,l,jk);

            Console.WriteLine("---Problem4---");
            int first, second, third, fourth;
            Console.WriteLine("Enter the numbers");
            first = Convert.ToInt32(Console.ReadLine());
            second = Convert.ToInt32(Console.ReadLine());
            third = Convert.ToInt32(Console.ReadLine());
            fourth = Convert.ToInt32(Console.ReadLine());
            int sum,avg;
            sum = first + second + third + fourth;
            avg = sum / 4;
            Console.WriteLine("{0}/4={1}", sum, avg);

            Console.WriteLine("---Problem 5---");
            int x, y, z;
            Console.WriteLine("Enter the numbers");
            x=Convert.ToInt32(Console.ReadLine());
            y=Convert.ToInt32(Console.ReadLine());
            z=Convert.ToInt32(Console.ReadLine());
            int pi = (x + y) * z;
            int ip = (x * y) + (y * z);
            Console.WriteLine("(x+y).z={0}",pi);
            Console.WriteLine("(x.y)+(y.z)={0}",ip);

            Console.WriteLine("---Problem6---");
            int age;
            Console.WriteLine("Enter your age");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than {0}", age);

            Console.WriteLine("--Problem 7---");
            int n;
            n= Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < 4; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0} {0} {0} {0}", n);
                else
                    Console.WriteLine("{0}{0}{0}{0}", n);

            }
            Console.WriteLine("---Problem8---");
            int rect;
            rect=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", rect);
            int re = 0;
            while (re < 3)
            {
                Console.WriteLine("{0} {0}", rect);
                re++;
            }
            Console.WriteLine("{0}{0}{0}", rect);

            Console.WriteLine("---Problem9---");
            int celsius;
            celsius=Convert.ToInt32(Console.ReadLine());
            int kelvin = 273 + celsius;
            Console.WriteLine("Kelvin value is {0} degree K", kelvin);
            int fahren = ((celsius * 9) / 5) + 32;
            Console.WriteLine("Fahrenheit value is {0} degree F", fahren); 

            Console.WriteLine("--Problem 10---");
            int pos, neg;
            pos=Convert.ToInt32(Console.ReadLine());
            neg=Convert.ToInt32(Console.ReadLine());
            if ((pos < 0 && neg > 0) || (pos > 0 && neg < 0))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.WriteLine("---Problem 11---");
            int mtr;
            Console.WriteLine("Enter meter");
            mtr = Convert.ToInt32(Console.ReadLine());
            float km = mtr / 1000;
            Console.WriteLine("meter to km is {0}", km);
            int kilo;
            Console.WriteLine("Enter kilometer");
            kilo= Convert.ToInt32(Console.ReadLine());
            int meter;
            meter = 1000 * kilo;
            Console.WriteLine("km to meter is {0}",meter);
            Console.WriteLine("---Problem 11---");
            int usd;
            usd = Convert.ToInt32(Console.ReadLine());
            double rupee = 79.62 * usd;
            Console.WriteLine("usd to rupee is {0}", rupee);

            Console.WriteLine("---Problem 12---");
            string name = String.Empty;
             name = Console.ReadLine();
            int pp = Int32.Parse(name);
            if (!String.IsNullOrEmpty(name))
            {
                Console.WriteLine("string is {0}",pp);
            }
            else
            { 
                Console.WriteLine("may be null or number");
            }

            Console.ReadLine();
        }
    }
}