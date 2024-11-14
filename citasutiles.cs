using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_EXAMEN
{
    using T3_EXAMEN;
    internal class citasutiles
    {


        public static void CrearCita(List<citas> citas1)
        {
            Console.Write("Ingrese el número de la cita: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el código del estudiante: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la universidad del estudiante: ");
            string universidad = Console.ReadLine();

            Console.Write("Ingrese la enfermedad: ");
            string enfermedad = Console.ReadLine();

            Console.Write("Ingrese el precio de la cita: ");
            double precio = double.Parse(Console.ReadLine());

            estudiante estudiante = new estudiante { codigo = codigo, nombre = nombre, universidad = universidad };
            citas cita = new citas
            {
                numero = numero,
                estudiante = estudiante,
                enfermedad = enfermedad,
                precio = precio
            };

            citas.Add(citas1);
            Console.WriteLine("Cita creada exitosamente.\n");
        }

        public static void ListarCitas(List<citas> citas)
            {

                double totalPrecio = 0;

                Console.WriteLine("Listado de Citas Médicas:");
                Console.WriteLine("--------------------------");

                foreach (var cita1 in citas)
                {

                    Console.WriteLine($"Número: {cita1.numero}");
                    Console.WriteLine($"Enfermedad: {cita1.enfermedad}");
                    Console.WriteLine($"Nombre del Estudiante: {cita1.estudiante.nombre}");
                    Console.WriteLine($"Universidad del Estudiante: {cita1.estudiante.universidad}");
                    Console.WriteLine($"Precio: {cita1.precio:C}");
                    Console.WriteLine("--------------------------");


                    

                    foreach (var citass in citas)
                    {
                        Console.WriteLine(cita1.ToString());

                        totalPrecio += cita1.precio;
                    }

                    Console.WriteLine($"\nTotal de precios de todas las citas: {totalPrecio:C}\n");
                }

                 public static void ModificarUniversidades(List<citas> citas)
                {
                    Console.Write("Ingrese el texto a buscar para modificar en las universidades: ");
                    string textoBuscado = Console.ReadLine();

                    Console.Write("Ingrese el texto para reemplazar: ");
                    string textoReemplazo = Console.ReadLine();

                    foreach (var cita in citas)
                    {
                        if (cita.estudiante.universidad.Contains(textoBuscado))
                        {
                            cita.estudiante.universidad = cita.estudiante.universidad.Replace(textoBuscado, textoReemplazo);
                        }
                    }

                    Console.WriteLine("Modificación masiva realizada.\n");
                }
            }







        }
    }
}


