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
            this.poY=poY;
        }
        public virtual void Dibuja()
        {
            Console.WriteLine("Se dibujó una figura de color {0} en la posición: ({1},{2})",color,poX,poY);
        }
    }
    class Rectangulo:Figura
    {
        public Rectangulo(string color, int poX, int poY):base(color,poX,poY)
        {
            color="blanco";
            poX=10;
            poY=10;
        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibujó un rectangulo de color {0} en la posición ({1},{2})", color, poX,poY);
        }
    }
    class Circulo:Figura
    {
        public int radio=10;
        public Circulo(string color, int poX, int poY):base(color, poX,poY)
        {
            color="negro";
            poX=10;
            poY=10;
        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibujó un circulo de color {0} en la posición ({1},{2})", color, poX,poY);
        }
    }
    class Triangulo:Figura
    {
        public Triangulo(string color, int poX, int poY):base(color,poX,poY)
        {
            color="blanco";
            poX=10;
            poY=10;
        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibujó un triangulo de color {0} en la posición ({1},{2})", color, poX,poY);
        }
    }
    class Cuadrado:Figura
    {
        public Cuadrado(string color, int poX, int poY):base(color,poX,poY)
        {
            color="blanco";
            poX=10;
            poY=10;
        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibujó un cuadrado de color {0} en la posición ({1},{2})", color, poX,poY);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras=new List<Figura>();
            Rectangulo a=new Rectangulo("rojo",60,100);
            figuras.Add(a);
            figuras.Add(new Circulo("azul",52,160));
            figuras.Add(new Triangulo("verde",40,40));
            figuras.Add(new Cuadrado("amarillo",81,90));
            foreach (var f in figuras)
            {
                f.Dibuja();
            }
        }
    }
}
