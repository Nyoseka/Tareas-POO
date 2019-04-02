## Tarea Unidad 4
### Polimorfismo

**1. Considera el siguiente fragmento de programa:**

using System;

class A

    {

    public int a;

    public A()

        {

        a = 10;

        }

    public _______ string Display()

      {

      return a.ToString();

      }

    }

class B:A

   {

   public int b;

   public B():base()

   {

    b = 15;

   }

  // #########################################

*#  Después de contestar la pregunta 1*              

*#  Redefine el método Display( ) en este espacio,  debe regresar el campo b como string.*

 //  #########################################

}

 class Program

  {

   public static void Main()

   {

  A objA = new A();

  B objB = new B();

  Console.WriteLine(objA.Display()); ////  (1 )

  Console. WriteLine(objB.Display()); ////  ( 2)

  }

  }

*1.1. ¿Qué valores imprimen las lineas (1) y (2)?*
ObjA: 10
ObjB: 10

*1.2.  Redefine el método Display en el espacio indicado,*

*una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2)?.*
ObjA: 10
ObjB: 15

*1.3. ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?*
override

**2. Considera el siguiente fragmento de programa:**

using System;

using System.Collections.Generic;

 ________ class Musico

    {

    public string nombre;

    public Musico (string n)

        {

         nombre = n;

        }

   public abstract (A) void Afina();  (B)

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

}

*2.1. Completa el programa.*

*2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?*
Falta colocar la palabra abstract en los métodos, además de colocar punto y coma para poder redefinirlos más adelante.

*2.3. ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?*

*2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?*

*2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?*

**3. Implementa el programa utilizando interfaces en lugar de herencia.**

