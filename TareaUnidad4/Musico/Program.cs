using System;
using System.Collections.Generic;

namespace Musico
{
 /* 
   public (C) string Display()

      { 

       return nombre;

      }

   }

class Bajista; Musico

  {

    public string instrumento;

    public Bajista (string n, string i ) ......

    .........

    public _________ Afina()

      {

      ________________

      }

 }

class Guitarrista ____________

     {

     public instrumento;

      // Falta el constructor y otras cosas??

 

     }
class Program

 {
  public static Main()
   {
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
        public abstract string Display()
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
