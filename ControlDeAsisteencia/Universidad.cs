using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAsisteencia
{
    public class Universidad
    {
        public class Estudiante
        {
            public string Nombre { get; set; }
            public int TotalSesiones { get; set; }
            public int SesionesAsistidas { get; set; }


            public Estudiante(string nombre, int totalSesiones, int sesionesAsistidas)
            {
                Nombre = nombre;
                TotalSesiones = totalSesiones;
                SesionesAsistidas = sesionesAsistidas;
            }


            public class Asistencia
            {

                public static double CalcularPorcentaje(int totalSesiones, int sesionesAsistidas)
                {
                    if (totalSesiones == 0)
                    {
                        return 0;
                    }
                    return (double)sesionesAsistidas / totalSesiones * 100;
                }


                public static bool CumpleMinimo(int totalSesiones, int sesionesAsistidas)
                {
                    return CalcularPorcentaje(totalSesiones, sesionesAsistidas) >= 75;
                }
            }


        }
    }

    public static class EstudianteExtensions
    {

        public static void MostrarInformacion(this Universidad.Estudiante estudiante)
        {

            double porcentaje = Universidad.Estudiante.Asistencia.CalcularPorcentaje(estudiante.TotalSesiones, estudiante.SesionesAsistidas);


            bool cumpleMinimo = Universidad.Estudiante.Asistencia.CumpleMinimo(estudiante.TotalSesiones, estudiante.SesionesAsistidas);


            Console.WriteLine($"Nombre: {estudiante.Nombre}");
            Console.WriteLine($"Total de Sesiones: {estudiante.TotalSesiones}");
            Console.WriteLine($"Sesiones Asistidas: {estudiante.SesionesAsistidas}");
            Console.WriteLine($"Porcentaje de Asistencia: {porcentaje:0.00}%");
            Console.WriteLine(cumpleMinimo ? "Cumple con el mínimo de asistencia (75%)." : "NO cumple con el mínimo de asistencia (75%).");
        }
    }

}
