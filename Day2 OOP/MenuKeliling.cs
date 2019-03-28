using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_OOP
{
    class MenuKeliling
    {
        static void Main(string[] args)
        {
            int menus;
            decimal number1;
            decimal number2;
            decimal number3;
            decimal number4;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("-----------MENU KELILING------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("1. Segitiga");
            Console.WriteLine("2. Lingkaran");
            Console.WriteLine("3. Persegi Panjang");
            Console.WriteLine("4. Trapesium");
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------");
            Console.Write("Pilih Menu : ");
            menus = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            
            if (menus == 1)
            {
                Console.WriteLine("TRIANGLE");
                Console.Write("Masukan SISI pertama : ");
                number1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Masukan SISI kedua   : ");
                number2 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Masukan SISI ketiga  : ");
                number3 = Convert.ToDecimal(Console.ReadLine());

                Triangle p;
                p = new Triangle(number1, number2, number3);
                decimal c = p.proccesing();
                Console.WriteLine("Result : " + c);
                Console.Read();
            }else if(menus == 2)
            {
                Console.WriteLine("CIRCLE");
                Console.Write("Masukan Diameter : ");
                number1 = Convert.ToDecimal(Console.ReadLine());

                Circle p;
                p = new Circle(number1);
                decimal c = p.proccesing();
                Console.WriteLine("Result : " + c);
                Console.Read();
            }else if(menus == 3)
            {
                Console.WriteLine("RECTANGLE");
                Console.Write("Masukan SISI pertama : ");
                number1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Masukan SISI kedua   : ");
                number2 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Masukan SISI ketiga  : ");
                number3 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Masukan SISI keEmpat  : ");
                number4 = Convert.ToDecimal(Console.ReadLine());

                Rectangle p;
                p = new Rectangle(number1, number2, number3, number4);
                decimal c = p.proccesing();
                Console.WriteLine("Result : " + c);
                Console.Read();
            }else if (menus == 4)
            {
                Console.WriteLine("TRAPESIUM");
                Console.Write("Masukan SISI pertama : ");
                number1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Masukan SISI kedua   : ");
                number2 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Masukan SISI ketiga  : ");
                number3 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Masukan SISI keEmpat  : ");
                number4 = Convert.ToDecimal(Console.ReadLine());

                Trapesium p;
                p = new Trapesium(number1, number2, number3, number4);
                decimal c = p.proccesing();
                Console.WriteLine("Result : " + c);
                Console.Read();
            }else
            {
                Console.WriteLine("Siji tekan papat tok gan, kok koe milih selain iku");
                Console.Read();
            }
        }
        public abstract class Process
        {
            public abstract decimal proccesing();
        }

        public class Triangle : Process
        {
            public decimal sidea;
            public decimal sideb;
            public decimal sidec;
            public Triangle(decimal a = 0, decimal  b = 0, decimal c = 0)
            {
                sidea = b;
                sideb = a;
                sidec = c;
            }
            public override decimal proccesing()
            {
                return (sidea + sideb + sidec);
            }
        }
        public class Circle : Process
        {
            public decimal Pi = 22/7;
            public decimal Diameter;
            public Circle(decimal a = 0)
            {
                Diameter = a;
            }
            public override decimal proccesing()
            {
                return (Pi * Diameter);
            }
        }
        public class Rectangle : Process
        {
            public decimal sidea;
            public decimal sideb;
            public decimal sidec;
            public decimal sided;
            public Rectangle(decimal a = 0, decimal b = 0, decimal c = 0, decimal d = 0)
            {
                sidea = b;
                sideb = a;
                sidec = c;
                sided = d;
            }
            public override decimal proccesing()
            {
                return (sidea + sideb + sidec + sided);
            }
        }
        public class Trapesium : Process
        {
            public decimal sidea;
            public decimal sideb;
            public decimal sidec;
            public decimal sided;
            public Trapesium(decimal a = 0, decimal b = 0, decimal c = 0, decimal d = 0)
            {
                sidea = b;
                sideb = a;
                sidec = c;
                sided = d;
            }
            public override decimal proccesing()
            {
                return (sidea + sideb + sidec + sided);
            }
        }
    }
}
