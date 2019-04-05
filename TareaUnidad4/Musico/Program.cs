using System;
using System.Collections.Generic;

namespace Musico
{
    abstract class Musico
    {
        public string nombre;
        public Musico(string nombre)
        {
            this.nombre=nombre;
        }
        public abstract void Afina();
        public abstract string Display();
    }
    class Bajista:Musico
    {
        public string instrumento;
        public Bajista(string nombre):base(nombre)
        {
            this.nombre=nombre;
        }
        public Bajista(string nombre, string i):base(nombre)
        {
            this.nombre=nombre;
            instrumento=i;
        }
        public override void Afina()
        {
            Console.WriteLine("*afina bajo*");
        }
        public override string Display()
        {
            return nombre;
        }
    }
    class Guitarrista:Musico
    {
        public string instrumento;
        public Guitarrista(string nombre):base(nombre)
        {
            this.nombre=nombre;
        }
        public Guitarrista(string nombre, string instrumento):base(nombre)
        {
            this.nombre=nombre;
            this.instrumento=instrumento;
        }
        public override void Afina()
        {
            Console.WriteLine("*afina guitarra*");
        }
        public override string Display()
        {
            return nombre;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bajista b = new Bajista("Flea");
            Guitarrista g = new Guitarrista("Santana");
            List<Musico> musicos=new List<Musico>();
            musicos.Add(b);
            musicos.Add(g);
            foreach (var Musico in musicos)
            {
                musicos.Display();
            }
        }
    }
}
