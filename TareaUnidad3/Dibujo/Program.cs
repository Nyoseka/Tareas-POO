using System;
using System.Collections.Generic;

namespace Dibujo
{
    class Figura
    {
        public string color;
        public int poX;
        public int poY;
        public Figura()
        {
            color=" ";
            poX=10;
            poY=10;
        }
        public Figura(string color, int poX, int poY)
        {
            this.color=color;
            this.poX=poX;
            this.poY;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
