using System;
using System.Collections.Generic;

namespace Musico
{
 /* 
  Musico m = new Musico("Django"); (D)

  Bajista b = new Bajista("Flea");

  Guitarrista g = new Guitarrista("Santana");

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
        public virtual string Afina(string a)
        {
            return a= string.Format("*afina su instrumento*");
        }
    }
    class Guitarrista:Musico
    {
        public string instrumento;
        public Guitarrista:base(nombre)
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
