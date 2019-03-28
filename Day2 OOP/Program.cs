using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_OOP
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Encapsulation -> pembatasan akses agar tidak bisa diakses secara langsung----
        //    parent bukaDompet = new parent();                                            
        //    int dompetNya = bukaDompet.a();
        //    //----------------PemanggilanPolymorphism--------------------
        //    int number, number1;
        //    Console.Write("Insert number pertama gan : ");
        //    number = Convert.ToInt16(Console.ReadLine());
        //    Console.Write("Insert number ke 2 gan : ");
        //    number1 = Convert.ToInt16(Console.ReadLine());
        //    Sub p;
        //    p = new Sub(number,number1);
        //    double c = p.proccesing();
        //    Console.WriteLine("Result : " + c);
        //    Console.Read();
        //}   
    }
    public class parent
    {
        public int c,d;
        private int wallet = 10000;
        public int a()
        {
            return wallet;
        }
    }

    //Inheritance -> pewaarisan sifat dari parent class
    public class child : parent
    {
        public int Method1()
        {
            return (c * d);
        }
    }

    //Polymorpism -> Banyak bentuk method dan bentuk implementasinya
   
    public abstract class Process
    {
        public abstract double proccesing();
    }

    public class Sub : Process
    {
        public double alas;
        public double tall;
        public Sub(double a = 0, double b = 0)
        {
            tall = b;
            alas = a;
        }
        public override double proccesing()
        {
            return (0.5 * alas * tall);
        }
    }

    //class subProcess
    //{
    //    static void main(string[] args)
    //    {
    //        Process p = new Sub(10, 7);
    //        decimal c = p.proccesing();
    //        Console.WriteLine("Result : " + c);

    //    }
    //}
}
