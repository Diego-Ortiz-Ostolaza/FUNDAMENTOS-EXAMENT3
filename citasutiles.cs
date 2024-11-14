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
<<<<<<< HEAD
        
        public static void CrearCita(List<citas> citas1)

        {
            List<citas> citas = new List<citas>();
=======

        public static void CrearCita(List<citas> citas1)
        {
>>>>>>> main
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
            citas cita = new citas {
                numero = numero, estudiante = estudiante, enfermedad = enfermedad, precio = precio };

<<<<<<< HEAD
            citas.Add(cita);
=======
            citas.(citas1);
>>>>>>> main
            Console.WriteLine("Cita creada exitosamente.\n");
        }

        public static void ListarCitas(List<citas> citas)
        {
<<<<<<< HEAD
            double totalPrecio = 0; 

            Console.WriteLine("Listado de Citas Médicas:");
            Console.WriteLine("--------------------------");

            foreach (var cita in citas)
            {
                
                Console.WriteLine($"Número: {cita.numero}");
                Console.WriteLine($"Enfermedad: {cita.enfermedad}");
                Console.WriteLine($"Nombre del Estudiante: {cita.estudiante.nombre}");
                Console.WriteLine($"Universidad del Estudiante: {cita.estudiante.universidad}");
                Console.WriteLine($"Precio: {cita.precio:C}");
                Console.WriteLine("--------------------------");

=======
            double totalPrecio = 0;

            foreach (var cita in citas)
            {
                Console.WriteLine(cita.ToString());
>>>>>>> main
                totalPrecio += cita.precio;
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

