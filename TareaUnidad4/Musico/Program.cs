using System;
using System.Collections.Generic;

namespace Musico
{
 /* 
  Musico [] m = ____________________

  m[0] = b;

  m[1] = g;

 

  foreach ( ___________)

       _____________________

 

 Console.ReadKey();

  

 }

} */

    abstract class Musico
    {
        public string nombre;
        public Musico(string n)
        {
            nombre=n;
        }
        public abstract void Afina();
        public virtual string Display()
        {
            return n;
        }
    }
    class Bajista:Musico
    {
        public string instrumento;
        public Bajista(string n, string i):base(nombre)
        {
            nombre=n;
            instrumento=i;
        }
        public override void Afina()
        {
            Console.WriteLine("*afina bajo*")
        }
        public override string Display()
        {
            return n;
        }
    }
    class Guitarrista:Musico
    {
        public string instrumento;
        public Guitarrista(string n, string i):base(nombre)
        {
            nombre=n;
            instrumento=i;
        }
        public override void Afina()
        {
            Console.WriteLine("*afina guitarra*");
        }
        public override string Display()
        {
            return n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Musico> musicos=new <List>();
            Bajista b = new Bajista("Flea");
            Guitarrista g = new Guitarrista("Santana");
        }
    }
}
