using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

 
internal class Program
{
  
     //Funcion//
        static double CalcularArea1(double baseRectangulo, double alturaRectangulo)
    {
        return baseRectangulo * alturaRectangulo;
    }
       static double CalcularArea2(double baseTriangulo, double alturaTriangulo)
    {
        return (baseTriangulo * alturaTriangulo) / 2;
    }
    
     static double CalcularArea3(double Pi, double radioCircunferencia)
    {
        return Pi *(radioCircunferencia * radioCircunferencia);
    }

      static void Main(string[] args)
     { 
        Console.WriteLine("Calculadora de Áreas");

       
        //Menú de opciones//
        Console.WriteLine("Elija una opcion:");
        Console.WriteLine("1. para Area de Triangulo");
        Console.WriteLine("2. para Area de Rectangulo");
        Console.WriteLine("3. para Area de un Circulo\n");

        //solicitar Datos//
        double opcion = double.Parse(Console.ReadLine());

       switch (opcion)
        {
            case 1:

             Console.WriteLine("\nIngrese la Base del Rectangulo en (cm)");
             double baseRectangulo = double.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese la Altura del Rectangulo en (cm)");
             double alturaRectangulo = double.Parse(Console.ReadLine());
             Console.WriteLine($"\nEl Area del Rectangulo es: {CalcularArea1(baseRectangulo, alturaRectangulo)} cm");
             break;
               
 
            case 2:
            
             Console.WriteLine("\nIngrese la Basedel Triangulo en (cm)");
             double baseTriangulo = double.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese la Altura en (cm)");
             double alturaTriangulo = double.Parse(Console.ReadLine());
             Console.WriteLine($"\nEl Area del Triangulo es: {CalcularArea2(baseTriangulo, alturaTriangulo)} cm");
             break;
            
            case 3:

             Console.WriteLine("Ingrese el radiode circunferencia");
             double radioCircunferencia = double.Parse(Console.ReadLine());            
            double Pi = 3.1416;
             Console.WriteLine($"\nEl Area de la Circunferencia es: {CalcularArea3(Pi, radioCircunferencia)} cm");
             break;

            default:
            
            Console.WriteLine("Opcion Invalida,intente de nuevo");
            break;


        }
       }

        }



 