using System;
using System.Collections.Generic;

namespace Interfaces
{
    interface IAfinable
    {
        void Afina();
    }
    class Musico
    {
        public string nombre;
        public Musico(string n)
        {
            nombre=n;
        }
        public virtual string Display()
        {
            return nombre;
        }
    }

    class Bajista:Musico,IAfinable
    {
        public string instrumento;
        public Bajista(string n, string i):base(nombre)
        {
            nombre=n;
            instrumento=i;
        }
        public override void Afina()
        {
            Console.WriteLine("afina bajo");
        }
        public override string Display()
        {
            return nombre;
        }
    }
    class Guitarrista:Musico,IAfinable
    {
        public string instrumento;
        public Guitarrista(string nombre, string instrumento):base(nombre)
        {
            nombre=n;
            instrumento=i;
        }
        public override void Afina()
        {
            Console.WriteLine("afina guitarra");
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
            List<Musico> musicos=new List<Musico>();
            Bajista b = new Bajista("Flea");
            Guitarrista g = new Guitarrista("Santana");
            musicos.Add(b);
            musicos.Add(g);
            foreach (var m in musicos)
            {
                (musicos as IAfinable).Afina(m);
                musicos.Display(m);
            }
        }
    }
}
