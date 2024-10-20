using System;
using System.Text.RegularExpressions;

namespace Prototipo_con_Ventanas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CrudAlumno crudAlumno = new CrudAlumno();
            CrudMateria crudMateria = new CrudMateria();
            CrudMaestro crudMaestro = new CrudMaestro();
            CrudGrupo crudGrupo = new CrudGrupo();
            CrudCarrera crudCarrera = new CrudCarrera();

            string opcion = "";

            while (opcion != "6") // Opción para salir
            {
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1. Gestionar Alumnos");
                Console.WriteLine("2. Gestionar Materias");
                Console.WriteLine("3. Gestionar Maestros");
                Console.WriteLine("4. Gestionar Grupos");
                Console.WriteLine("5. Gestionar Carreras");
                Console.WriteLine("6. Salir");
                Console.Write("Elige una opción: ");
                opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    MenuAlumnos(crudAlumno);
                }
                else if (opcion == "2")
                {
                    MenuMaterias(crudMateria);
                }
                else if (opcion == "3")
                {
                    MenuMaestros(crudMaestro);
                }
                else if (opcion == "4")
                {
                    MenuGrupos(crudGrupo);
                }
                else if (opcion == "5")
                {
                    MenuCarreras(crudCarrera);
                }
                else if (opcion == "6")
                {
                    Console.WriteLine("Saliendo del programa...");
                }
                else
                {
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.\n");
                }
            }

            static void MenuAlumnos(CrudAlumno crudAlumno)
            {
                string opcionAlumno = "";

                while (opcionAlumno != "5")
                {
                    Console.WriteLine("Menú de Alumnos:");
                    Console.WriteLine("1. Agregar Alumno");
                    Console.WriteLine("2. Ver Alumno");
                    Console.WriteLine("3. Actualizar Alumno");
                    Console.WriteLine("4. Eliminar Alumno");
                    Console.WriteLine("5. Volver al Menú Principal");
                    Console.Write("Elige una opción: ");
                    opcionAlumno = Console.ReadLine();

                    if (opcionAlumno == "1")
                    {
                        Alumno alumno = new Alumno();
                        Console.Write("ID: ");
                        alumno.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nombre: ");
                        alumno.Nombre = Console.ReadLine();
                        Console.Write("Apellido: ");
                        alumno.Apellido = Console.ReadLine();
                        Console.Write("Carrera: ");
                        alumno.Carrera = Console.ReadLine();
                        Console.Write("Promedio: ");
                        alumno.Promedio = Convert.ToDouble(Console.ReadLine());
                        crudAlumno.Crear(alumno);
                    }
                    else if (opcionAlumno == "2")
                    {
                        Console.Write("ID del Alumno: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Alumno alumno = crudAlumno.Leer(id);
                        if (alumno != null)
                        {
                            Console.WriteLine($"ID: {alumno.Id}, Nombre: {alumno.Nombre}, Apellido: {alumno.Apellido}, Carrera: {alumno.Carrera}, Promedio: {alumno.Promedio}\n");
                        }
                        else
                        {
                            Console.WriteLine("Alumno no encontrado.\n");
                        }
                    }
                    else if (opcionAlumno == "3")
                    {
                        Alumno alumno = new Alumno();
                        Console.Write("ID del Alumno: ");
                        alumno.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nuevo Nombre: ");
                        alumno.Nombre = Console.ReadLine();
                        Console.Write("Nuevo Apellido: ");
                        alumno.Apellido = Console.ReadLine();
                        Console.Write("Nueva Carrera: ");
                        alumno.Carrera = Console.ReadLine();
                        Console.Write("Nuevo Promedio: ");
                        alumno.Promedio = Convert.ToDouble(Console.ReadLine());
                        crudAlumno.Actualizar(alumno);
                    }
                    else if (opcionAlumno == "4")
                    {
                        Console.Write("ID del Alumno: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        crudAlumno.Eliminar(id);
                    }
                    else if (opcionAlumno == "5")
                    {
                        Console.WriteLine("Volviendo al Menú Principal...\n");
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.\n");
                    }
                }
            }

            static void MenuMaterias(CrudMateria crudMateria)
            {
                string opcionMateria = "";

                while (opcionMateria != "5")
                {
                    Console.WriteLine("Menú de Materias:");
                    Console.WriteLine("1. Agregar Materia");
                    Console.WriteLine("2. Ver Materia");
                    Console.WriteLine("3. Actualizar Materia");
                    Console.WriteLine("4. Eliminar Materia");
                    Console.WriteLine("5. Volver al Menú Principal");
                    Console.Write("Elige una opción: ");
                    opcionMateria = Console.ReadLine();

                    if (opcionMateria == "1")
                    {
                        Materia materia = new Materia();
                        Console.Write("ID: ");
                        materia.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nombre: ");
                        materia.Nombre = Console.ReadLine();
                        Console.Write("Créditos: ");
                        materia.Creditos = Convert.ToInt32(Console.ReadLine());
                        crudMateria.Crear(materia);
                    }
                    else if (opcionMateria == "2")
                    {
                        Console.Write("ID de la Materia: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Materia materia = crudMateria.Leer(id);
                        if (materia != null)
                        {
                            Console.WriteLine($"ID: {materia.Id}, Nombre: {materia.Nombre}, Créditos: {materia.Creditos}\n");
                        }
                        else
                        {
                            Console.WriteLine("Materia no encontrada.\n");
                        }
                    }
                    else if (opcionMateria == "3")
                    {
                        Materia materia = new Materia();
                        Console.Write("ID de la Materia: ");
                        materia.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nuevo Nombre: ");
                        materia.Nombre = Console.ReadLine();
                        Console.Write("Nuevos Créditos: ");
                        materia.Creditos = Convert.ToInt32(Console.ReadLine());
                        crudMateria.Actualizar(materia);
                    }
                    else if (opcionMateria == "4")
                    {
                        Console.Write("ID de la Materia: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        crudMateria.Eliminar(id);
                    }
                    else if (opcionMateria == "5")
                    {
                        Console.WriteLine("Volviendo al Menú Principal...\n");
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.\n");
                    }
                }
            }

            static void MenuMaestros(CrudMaestro crudMaestro)
            {
                string opcionMaestro = "";

                while (opcionMaestro != "5")
                {
                    Console.WriteLine("Menú de Maestros:");
                    Console.WriteLine("1. Agregar Maestro");
                    Console.WriteLine("2. Ver Maestro");
                    Console.WriteLine("3. Actualizar Maestro");
                    Console.WriteLine("4. Eliminar Maestro");
                    Console.WriteLine("5. Volver al Menú Principal");
                    Console.Write("Elige una opción: ");
                    opcionMaestro = Console.ReadLine();

                    if (opcionMaestro == "1")
                    {
                        Maestro maestro = new Maestro();
                        Console.Write("ID: ");
                        maestro.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nombre: ");
                        maestro.Nombre = Console.ReadLine();
                        Console.Write("Apellido: ");
                        maestro.Apellido = Console.ReadLine();
                        Console.Write("Contacto: ");
                        maestro.Contacto = Console.ReadLine();
                        crudMaestro.Crear(maestro);
                    }
                    else if (opcionMaestro == "2")
                    {
                        Console.Write("ID del Maestro: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Maestro maestro = crudMaestro.Leer(id);
                        if (maestro != null)
                        {
                            Console.WriteLine($"ID: {maestro.Id}, Nombre: {maestro.Nombre}, Apellido: {maestro.Apellido}, Contacto: {maestro.Contacto}\n");
                        }
                        else
                        {
                            Console.WriteLine("Maestro no encontrado.\n");
                        }
                    }
                    else if (opcionMaestro == "3")
                    {
                        Maestro maestro = new Maestro();
                        Console.Write("ID del Maestro: ");
                        maestro.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nuevo Nombre: ");
                        maestro.Nombre = Console.ReadLine();
                        Console.Write("Nuevo Apellido: ");
                        maestro.Apellido = Console.ReadLine();
                        Console.Write("Nuevo Contacto: ");
                        maestro.Contacto = Console.ReadLine();
                        crudMaestro.Actualizar(maestro);
                    }
                    else if (opcionMaestro == "4")
                    {
                        Console.Write("ID del Maestro: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        crudMaestro.Eliminar(id);
                    }
                    else if (opcionMaestro == "5")
                    {
                        Console.WriteLine("Volviendo al Menú Principal...\n");
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.\n");
                    }
                }
            }

            static void MenuGrupos(CrudGrupo crudGrupo)
            {
                string opcionGrupo = "";

                while (opcionGrupo != "5")
                {
                    Console.WriteLine("Menú de Grupos:");
                    Console.WriteLine("1. Agregar Grupo");
                    Console.WriteLine("2. Ver Grupo");
                    Console.WriteLine("3. Actualizar Grupo");
                    Console.WriteLine("4. Eliminar Grupo");
                    Console.WriteLine("5. Volver al Menú Principal");
                    Console.Write("Elige una opción: ");
                    opcionGrupo = Console.ReadLine();

                    if (opcionGrupo == "1")
                    {
                        Grupo grupo = new Grupo();
                        Console.Write("ID: ");
                        grupo.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nombre del Grupo: ");
                        grupo.Nombre = Console.ReadLine();
                        grupo.Alumnos = new List<Alumno>();
                        Console.WriteLine("Grupo creado.");
                        crudGrupo.Crear(grupo);
                    }
                    else if (opcionGrupo == "2")
                    {
                        Console.Write("ID del Grupo: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Grupo grupo = crudGrupo.Leer(id);
                        if (grupo != null)
                        {
                            Console.WriteLine($"ID: {grupo.Id}, Nombre del Grupo: {grupo.Nombre}");
                        }
                        else
                        {
                            Console.WriteLine("Grupo no encontrado.\n");
                        }
                    }
                    else if (opcionGrupo == "3")
                    {
                        Grupo grupo = new Grupo();
                        Console.Write("ID del Grupo: ");
                        grupo.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nuevo Nombre del Grupo: ");
                        grupo.Nombre = Console.ReadLine();
                        crudGrupo.Actualizar(grupo);
                    }
                    else if (opcionGrupo == "4")
                    {
                        Console.Write("ID del Grupo: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        crudGrupo.Eliminar(id);
                    }
                    else if (opcionGrupo == "5")
                    {
                        Console.WriteLine("Volviendo al Menú Principal...\n");
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.\n");
                    }
                }
            }

            static void MenuCarreras(CrudCarrera crudCarrera)
            {
                string opcionCarrera = "";

                while (opcionCarrera != "5")
                {
                    Console.WriteLine("Menú de Carreras:");
                    Console.WriteLine("1. Agregar Carrera");
                    Console.WriteLine("2. Ver Carrera");
                    Console.WriteLine("3. Actualizar Carrera");
                    Console.WriteLine("4. Eliminar Carrera");
                    Console.WriteLine("5. Volver al Menú Principal");
                    Console.Write("Elige una opción: ");
                    opcionCarrera = Console.ReadLine();

                    if (opcionCarrera == "1")
                    {
                        Carrera carrera = new Carrera();
                        Console.Write("ID: ");
                        carrera.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nombre de la Carrera: ");
                        carrera.Nombre = Console.ReadLine();
                        crudCarrera.Crear(carrera);
                    }
                    else if (opcionCarrera == "2")
                    {
                        Console.Write("ID de la Carrera: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Carrera carrera = crudCarrera.Leer(id);
                        if (carrera != null)
                        {
                            Console.WriteLine($"ID: {carrera.Id}, Nombre: {carrera.Nombre}\n");
                        }
                        else
                        {
                            Console.WriteLine("Carrera no encontrada.\n");
                        }
                    }
                    else if (opcionCarrera == "3")
                    {
                        Carrera carrera = new Carrera();
                        Console.Write("ID de la Carrera: ");
                        carrera.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nuevo Nombre de la Carrera: ");
                        carrera.Nombre = Console.ReadLine();
                        crudCarrera.Actualizar(carrera);
                    }
                    else if (opcionCarrera == "4")
                    {
                        Console.Write("ID de la Carrera: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        crudCarrera.Eliminar(id);
                    }
                    else if (opcionCarrera == "5")
                    {
                        Console.WriteLine("Volviendo al Menú Principal...\n");
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.\n");
                    }
                }
            }
        }
    }
    
}