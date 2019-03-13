using System;
using System.Collections.Generic;

namespace ProgFigura
{
    class Vector2D
    {
        public int x;
        public int y;
        public Vector2D(int x, int y)
        {
            this.x=x;
            this.y=y;
        }
        public override string ToString()
        {
            return String.Format("{0},{1}",x,y);
        }
    }
    
    abstract class Figura
    {
        public Vector2D position;
        public string fill, border;
        public Figura():this(new Vector(100,100))
        {

        }
        public Figura(Vector2D p)
        {
            position=p;
            fill="Blanco";
            border="Negro";
        }
        public abstract void Dibuja();
    }

    class Rectangulo:Figura
    {
        public Rectangulo(Vector2D position):base(p);
        {

        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un Rectangulo en {0}, de color {1} ",position,fill);
        }
    }
    class Circulo:Figura
    {
        private int Radio;
        public Circulo(Vector2D position, int Radio):base(p);
        {
            this.Radio=Radio;
        }
        public Circulo(int Radio):base()
        {
            this.Radio=10;
        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un circulo en {0} de color {1}",position, fill);
        }
    }
    class Poligono:Figura
    {
        public Poligono(Vector2D position):base(p);
        {
            
        }
        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un Rectangulo en {0}, de color {1} ",position,fill);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo a=new Rectangulo(new Vector2D(150,150));
            List<Figura> figuras=new List<Figura>();
            figuras.Add(a);
            figuras.Add(new Circulo(new Vector2D(100,100)));
            figuras.Add(new Poligono(new Vector2D(250,250)));
            foreach (f in figuras)
            {
                f.Dibuja();
            }
        }
    }
}
