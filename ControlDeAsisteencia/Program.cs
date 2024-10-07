using System;
using ControlDeAsisteencia; 

class Program
{
    static void Main(string[] args)
    {
       
        Universidad.Estudiante[] estudiantes = new Universidad.Estudiante[]
        {
            new Universidad.Estudiante("Abel Marin", 20, 15),
            new Universidad.Estudiante("Friederish Martinez", 25, 22),
            new Universidad.Estudiante("Kleomar Sandoval", 30, 20),
            new Universidad.Estudiante("Hernan Jiron", 20, 14)
        };

        bool salir = false;

        while (!salir)
        {
          
            Console.WriteLine("Menu de opciones:");
            Console.WriteLine("1. Ver tabla de estudiantes");
            Console.WriteLine("2. Ingresar mis propios datos");
            Console.WriteLine("3. Salir");
            Console.Write("Ingrese una opcion (1 al 3): ");
            string opcion = Console.ReadLine();

            
            switch (opcion)
            {
                case "1":
                    
                    Console.WriteLine("\n--- Tabla de Estudiantes ---\n");
                    foreach (var estudiante in estudiantes)
                    {
                        estudiante.MostrarInformacion();
                        Console.WriteLine(); 
                    }
                    break;

                case "2":
                    
                    Console.Write("Ingrese su nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese el total de sesiones: ");
                    int totalSesiones = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el numero de sesiones asistidas: ");
                    int sesionesAsistidas = int.Parse(Console.ReadLine());

                    
                    Universidad.Estudiante nuevoEstudiante = new Universidad.Estudiante(nombre, totalSesiones, sesionesAsistidas);

                  
                    nuevoEstudiante.MostrarInformacion();
                    break;

                case "3":
                    
                    salir = true;
                    Console.WriteLine("Gracias por utilizar el sistema :)");
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta..");
                    break;
            }

            
            Console.WriteLine();
        }
    }
}

