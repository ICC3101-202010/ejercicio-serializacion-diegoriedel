using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;

namespace Tarea_en_clases
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personas = new List<Person>();
            int numero;

            Console.WriteLine("¿Que quiere hacer?");
            Console.WriteLine("Crear pesona (1)");
            Console.WriteLine("Mostrar persona (2)");
            Console.WriteLine("Cargar las personas (3)");
            Console.WriteLine("Salir (9)");
            numero = Convert.ToInt32(Console.ReadLine());

            string nombre;
            string apellido;
            int edad;
            while (numero != 9)
            {
                if (numero == 1)
                {
                    Console.WriteLine("Ingerse datos de la persona: ");
                    Console.WriteLine("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Apellido: ");
                    apellido = Console.ReadLine();
                    Console.WriteLine("Edad: ");
                    edad = Convert.ToInt32(Console.ReadLine());

                    Person aa = new Person()
                    {
                        name = nombre,
                        lastname = apellido,
                        age = edad
                    };
                    personas.Add(aa);
                }
                else if (numero == 2)
                {
                    foreach (Person pe in personas)
                    {
                        Console.WriteLine("Nombre: "+ pe.name +" Apellido: "+ pe.lastname+" Edad: "+ pe.age);
                    }
                }
                Console.WriteLine("¿Que quiere hacer?");
                Console.WriteLine("Crear pesona (1)");
                Console.WriteLine("Mostrar persona (2)");
                Console.WriteLine("Cargar las personas (3)");
                Console.WriteLine("Salir (9)");
                numero = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
