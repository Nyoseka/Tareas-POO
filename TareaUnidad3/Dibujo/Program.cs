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
        public virtual void Dibuja()
        {
            Console.WriteLine("Figura de color {0} en la posición: ({1},{2})",color,poX,poY);
        }
    }
    class Rectangulo:Figura
    {
        string alto;
        string ancho;
        public Rectangulo(string color, int poX, int poY):base(color,poX,poY)
        {
            
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
