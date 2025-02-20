using System;
using System.Collections.Generic;

class Program
{
    static List<string> estudiantes = new List<string>();
    static List<double> calificaciones = new List<double>();

    static void Main(string[] args)

    {
        void LlamarMenu() {
            Console.WriteLine("\n1. Agregar estudiante");
            Console.WriteLine("2. Mostrar lista de estudiantes");
            Console.WriteLine("3. Calcular promedio de calificaciones");
            Console.WriteLine("4. Mostrar estudiante con la calificación más alta");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            
        }
        void IngresarEstudiantes()
        {
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la calificación del estudiante: ");
            double calificacion = double.Parse(Console.ReadLine());
            
            if (calificacion >=0 && calificacion <=100)
            {
                estudiantes.Add(nombre);
                calificaciones.Add(calificacion);
                Console.WriteLine("Estudiante agregado correctamente.");

            }else
            {
                Console.WriteLine("Calificacion No establecida entre el rango");
            }
            
            
        }
        void ListadoEstudiantes()
        {

            Console.WriteLine("\nLista de estudiantes:");
            for (int i = 0; i < estudiantes.Count; i++)
            {
                Console.WriteLine($"{estudiantes[i]} - Calificación: {calificaciones[i]}");
            }
        }
        void ImprimirPromedio()
        {
            double suma = 0;
            foreach (double calificacion in calificaciones)
            {
                suma += calificacion;
            }
            double promedio = suma / calificaciones.Count;
            Console.WriteLine($"El promedio de calificaciones es: {promedio}");
        }

        void CalificacionAlta()
        {
            double maxCalificacion = calificaciones[0];
            string estudianteMax = estudiantes[0];
            for (int i = 1; i < calificaciones.Count; i++)
            {
                if (calificaciones[i] > maxCalificacion)
                {
                    maxCalificacion = calificaciones[i];
                    estudianteMax = estudiantes[i];
                }
            }

            Console.WriteLine($"El estudiante con la calificación más alta es: {estudianteMax} con {maxCalificacion}");
        }

        Console.WriteLine("Bienvenido al sistema de gestión de estudiantes.");

        while (true)
        {
            LlamarMenu();

            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                IngresarEstudiantes(); 
            }
            else if (opcion == 2)
            {
                if (estudiantes.Count == 0)
                {
                    Console.WriteLine("No hay estudiantes registrados.");
                }
                else
                {
                    ListadoEstudiantes();
                }
            }
            else if (opcion == 3)
            {
                if (calificaciones.Count == 0)
                {
                    Console.WriteLine("No hay calificaciones registradas.");
                }
                else
                {
                    ImprimirPromedio();   
                }
            }
            else if (opcion == 4)
            {
                if (calificaciones.Count == 0)
                {
                    Console.WriteLine("No hay calificaciones registradas.");
                }
                else
                {
                    CalificacionAlta();
                }
            }
            else if (opcion == 5)
            {
                Console.WriteLine("Saliendo del sistema...");
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }
        }
    }
}
