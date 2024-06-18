using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    public static int opcion { get; private set; }

    public static double FahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double CelsiusAKelvin(double celsius)
        {
            return celsius + 273.15;
        }
       private static double CelsiusAFahrenheit(double celsius)
      {
        return celsius * 9 / 5 + 32;
      }

     static void Main(string[] args)
    {
        Console.WriteLine("Convertidor de Temperatura\n");
        Console.WriteLine("Elija una opcion");
        Console.WriteLine("1. para convertir Celsius a Fahrenheit");
        Console.WriteLine("2. para convertir Fahrenheit a Celsius");
        Console.WriteLine("3. para convertir Celsius a Kelvin");
        int opcion = int.Parse(Console.ReadLine());
       
      {
        switch (opcion)
        {
            case 1:

             Console.WriteLine("Ingrese la Temperatura en Celsius");
             double Celsius = double.Parse(Console.ReadLine());
             Console.WriteLine($"\n{Celsius} Celsius es igual a: {CelsiusAFahrenheit(Celsius)} Fahrenheit");
             break;

            case 2:
            
              Console.WriteLine("Ingrese la Temperatura en Fahrenheit");
              double Fahrenheit = double.Parse(Console.ReadLine());
              Console.WriteLine($"\n{Fahrenheit} Fahrenheit es igual a: {FahrenheitACelsius(Fahrenheit)} Celsius");
              break;
            
            case 3:

             Console.WriteLine("Ingrese la Temperatura en Celsius");
             Celsius = double.Parse(Console.ReadLine());
             Console.WriteLine($"\n{Celsius} Celsius es igual a: {CelsiusAKelvin(Celsius)} Kelvin");
             break;

            default:

            Console.WriteLine("Opcion Invalida,intente de nuevo");
            break;


        }
      }
    }
    
}