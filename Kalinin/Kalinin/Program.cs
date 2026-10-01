using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalinin
{
    internal class Program
    {
        class Computer
        {
            public int number;
            public int Gb;
            public double frequency;

            public void ShowData()
            {
                Console.WriteLine("Номер = " + number);
                Console.WriteLine("Памать в Гигабайтах = "+Gb);
                Console.WriteLine("Частота = "+frequency);
            }
            public void Calck()
            {
                int price = Gb * 100;
                Console.WriteLine("Стоимость Памяти "+price);
            }
        }
        static void Main(string[] args)
        {
            Computer pc = new Computer();
            pc.number = 123345 ;
            pc.Gb = 400;
            pc.frequency = 1.5;
            pc.ShowData();
            pc.Calck();
            Console.ReadLine();
        }

    }
}
