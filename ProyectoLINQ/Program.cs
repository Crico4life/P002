using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoLINQ
{
    class Program
    {
        public class Persona
        {
            public required string Nombre { get; set; }
            public int Edad { get; set; }
        }

        static void Main(string[] args)
        {
            // Ejecución Diferida
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            var consulta = numeros.Where(n => n > 3);
            Console.WriteLine("Ejecución Diferida:");
            foreach (var numero in consulta)
            {
                Console.WriteLine(numero); // Output: 4, 5
            }

            // Función Where
            var numerosMayoresQueTres = numeros.Where(n => n > 3);
            Console.WriteLine("\nFunción Where:");
            foreach (var numero in numerosMayoresQueTres)
            {
                Console.WriteLine(numero); // Output: 4, 5
            }

            // Where con Objetos
            List<Persona> personas = new List<Persona>
            {
                new Persona { Nombre = "Juan", Edad = 30 },
                new Persona { Nombre = "María", Edad = 25 },
                new Persona { Nombre = "Pedro", Edad = 40 }
            };

            var mayoresDeTreinta = personas.Where(p => p.Edad > 30);
            Console.WriteLine("\nWhere con Objetos:");
            foreach (var persona in mayoresDeTreinta)
            {
                Console.WriteLine(persona.Nombre); // Output: Pedro
            }

            // First & FirstOrDefault
            int primerNumero = numeros.First();
            int primerNumeroMayorQueTres = numeros.First(n => n > 3);
            int numeroInexistente = numeros.FirstOrDefault(n => n > 5);
            Console.WriteLine("\nFirst & FirstOrDefault:");
            Console.WriteLine(primerNumero); // 1
            Console.WriteLine(primerNumeroMayorQueTres); // 4
            Console.WriteLine(numeroInexistente); // 0

            // Last & LastOrDefault
            int ultimoNumero = numeros.Last();
            int ultimoNumeroMayorQueTres = numeros.Last(n => n > 3);
            int ultimoNumeroInexistente = numeros.LastOrDefault(n => n > 5);
            Console.WriteLine("\nLast & LastOrDefault:");
            Console.WriteLine(ultimoNumero); // 5
            Console.WriteLine(ultimoNumeroMayorQueTres); // 5
            Console.WriteLine(ultimoNumeroInexistente); // 0

            // Single & SingleOrDefault
            int unicoNumero = numeros.Single(n => n == 3);
            int unicoNumeroInexistente = numeros.SingleOrDefault(n => n == 6);
            Console.WriteLine("\nSingle & SingleOrDefault:");
            Console.WriteLine(unicoNumero); // 3
            Console.WriteLine(unicoNumeroInexistente); // 0

            // Filtrando por Tipo
            List<object> objetos = new List<object> { 1, "dos", 3, "cuatro" };
            var soloNumeros = objetos.OfType<int>();
            Console.WriteLine("\nFiltrando por Tipo:");
            foreach (var numero in soloNumeros)
            {
                Console.WriteLine(numero); // Output: 1, 3
            }

            // OrderBy & OrderByDescending
            var ordenAscendente = numeros.OrderBy(n => n);
            var ordenDescendente = numeros.OrderByDescending(n => n);
            Console.WriteLine("\nOrderBy & OrderByDescending:");
            Console.WriteLine("Orden Ascendente:");
            foreach (var numero in ordenAscendente)
            {
                Console.WriteLine(numero); // Output: 1, 2, 3, 4, 5
            }

            Console.WriteLine("Orden Descendente:");
            foreach (var numero in ordenDescendente)
            {
                Console.WriteLine(numero); // Output: 5, 4, 3, 2, 1
            }
        }
    }
}