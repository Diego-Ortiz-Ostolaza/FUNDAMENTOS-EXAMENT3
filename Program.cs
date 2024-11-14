using T3_EXAMEN;

estudiante estu = new estudiante();
citas citas = new citas();
<<<<<<< HEAD
List<citas> cit = new List<citas>();
=======
>>>>>>> main
byte opcion;
string regresar;

do
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("     CITAS MÉDICAS \n");

    Console.WriteLine("******** MENÚ ********");

    Console.WriteLine("* 1. Crear           *");

    Console.WriteLine("* 2. Lista           *");

    Console.WriteLine("* 3. Modifica Masivo *");

    Console.WriteLine("* 0. Salir           *");

    Console.WriteLine("**********************\n");



    Console.Write("Ingrese opcion: ");


    Console.ForegroundColor = ConsoleColor.Red;
    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)
    {

        Console.Write("Error: Ingrese opcion: ");

    }

    Console.ForegroundColor = ConsoleColor.DarkCyan;

    switch (opcion)
    {

        case 0: Environment.Exit(0); break;

<<<<<<< HEAD
        case 1: citasutiles.CrearCita(cit);   break;

        case 2: citasutiles.ListarCitas(cit);  break;

        case 3: citasutiles.ModificarUniversidades(cit); break;
=======
        case 1: break;

        case 2: break;

        case 3: break;
>>>>>>> main


    }

    Console.WriteLine("Desea regresar al menú? [si]: ");

    regresar = Console.ReadLine();

<<<<<<< HEAD

=======
>>>>>>> main
    Console.Clear();

} while (regresar == "si");
