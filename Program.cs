Using System;
namespace CS5 
{
class Program 
   {  
    static void Main(string[] args)
     {
      // 
      // Unidad 2: Funciones II 
      // Sesión 12: Intrucciones while 30092026
      // Sintaxis: while 
      // Inicialización;
      // while(expresión)
      // {
      //       Bloque de instrucciones 
      //       iterador;
      // }
      // iterar: repetir 
      // Ejemplo 1: Ciclo ascendente (rango de 1-3)
      // m: variable de control 
      int m = 1; // inicialización 
      while(m <= 3)
      { 
         //Bloque de instrucciones
         Console.WriteLine($"m: {m}");
         m += 1; // Iterador

      }
      // 1. Definir un ciclo para imprimir tu nombre 5 veces 
      // Nota: Para la expresion utilizar el operador <
      int f = 0; // inicialización 
      while(f < 5)
      { 
         Console.WriteLine("Fernando Hernandez");
         f += 1;

      }
      // Variable ciclo descendente 
      int d = 3;
      while (d >= 1)
      {
         Console.WriteLine($"d: {d}");
         d -= 1;   
      }
      // c. Incrementos
      // Secuencia: 3 6 9 12 15 18
      int i = 3;
      while (i <= 18)
      {
         Console.WriteLine($"i: {i}");
         i += 3;
      }
     
      // definir un ciclo para imprimir "331" 8 veces 
      // nota: para la solucion define un ciclo descendente con decrementos de 2 unidades
        int y = 15;
        while (y >= 1)
        {
            Console.WriteLine("331");
            y -= 2;
        }       
        // Actividad 1: Ciclo infinito 
        // 1. Definir ciclo infinito ascendente 
        // 2. Definir ciclo infinito descendente
        // Nota. para la solucion, utilizar el operador de difenrecia.
        // 1.-
        int h = 24;
        while (h != 0)
        {
            h += 43;
        }
        // 2. 
        int e = 999;
        while (e != 1000)
        {
            e -= 1;
        }

     }
   }
 }