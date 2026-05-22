using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {

        CasoList lista = new CasoList();

        Alumno a1 = new Alumno(1, "Juan", 8.5);
        Alumno a2 = new Alumno(2, "Ana", 9.2);
        Alumno a3 = new Alumno(3, "Pedro", 7.8);

        lista.AgregarAlumno(a1);
        lista.AgregarAlumno(a2);
        lista.AgregarAlumno(a3);

        Console.WriteLine("LISTA DE ALUMNOS");

        foreach (Alumno alumno in lista.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\nBUSCAR JUAN");

        Alumno? encontrado = lista.BuscarAlumnoPorNombre("Juan");

        if (encontrado != null)
        {
            Console.WriteLine(encontrado);
        }

        Console.WriteLine("\nBUSCAR MARIA");

        Alumno? noExiste = lista.BuscarAlumnoPorNombre("Maria");

        if (noExiste == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nELIMINAR ANA");

        lista.EliminarAlumno(a2);

        foreach (Alumno alumno in lista.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\nELIMINAR PRIMER ELEMENTO");

        lista.EliminarAlumnoPorPosicion(0);

        foreach (Alumno alumno in lista.RetornarLista())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary diccionario = new CasoDictionary();

        Alumno a1 = new Alumno(1, "Juan", 8.5);
        Alumno a2 = new Alumno(2, "Ana", 9.2);
        Alumno a3 = new Alumno(3, "Pedro", 7.8);

        diccionario.AgregarAlumno(100, a1);
        diccionario.AgregarAlumno(101, a2);
        diccionario.AgregarAlumno(102, a3);

        Console.WriteLine("DICCIONARIO DE ALUMNOS");

        foreach (var item in diccionario.RetornarDiccionario())
        {
            Console.WriteLine(
                "Legajo: " + item.Key +
                " - " + item.Value
            );
        }

        Console.WriteLine("\nBUSCAR LEGAJO 101");

        Alumno? encontrado = diccionario.BuscarAlumno(101);

        if (encontrado != null)
        {
            Console.WriteLine(encontrado);
        }

        Console.WriteLine("\nBUSCAR LEGAJO 999");

        Alumno? noExiste = diccionario.BuscarAlumno(999);

        if (noExiste == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nELIMINAR LEGAJO 100");

        diccionario.EliminarAlumno(100);

        foreach (var item in diccionario.RetornarDiccionario())
        {
            Console.WriteLine(
                "Legajo: " + item.Key +
                " - " + item.Value
            );
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq caso = new CasoLinq();

        Console.WriteLine("PRIMER LIBRO");
        var primero = caso.GetPrimero();
        if (primero != null) Console.WriteLine($"{primero.Id} - {primero.Titulo} - {primero.Precio:C}");

        Console.WriteLine("\nULTIMO LIBRO");
        var ultimo = caso.GetUltimo();
        if (ultimo != null) Console.WriteLine($"{ultimo.Id} - {ultimo.Titulo} - {ultimo.Precio:C}");

        Console.WriteLine("\nTOTAL PRECIOS");
        Console.WriteLine(caso.GetTotalPrecios().ToString("C"));

        Console.WriteLine("\nPROMEDIO PRECIOS");
        Console.WriteLine(caso.GetPromedioPrecios().ToString("C"));

        Console.WriteLine("\nLIBROS ID > 15");
        foreach (Libro libro in caso.GetListById())
        {
            Console.WriteLine($"{libro.Id} - {libro.Titulo} - {libro.Precio:C}");
        }

        Console.WriteLine("\nLIBROS FORMATEADOS");
        // Este queda igual porque ya devolvía un string formateado desde CasoLinq
        foreach (string libro in caso.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nMAYOR PRECIO");
        var mayor = caso.GetMayorPrecio();
        if (mayor != null) Console.WriteLine($"{mayor.Id} - {mayor.Titulo} - {mayor.Precio:C}");

        Console.WriteLine("\nMENOR PRECIO");
        var menor = caso.GetMenorPrecio();
        if (menor != null) Console.WriteLine($"{menor.Id} - {menor.Titulo} - {menor.Precio:C}");

        Console.WriteLine("\nMAYORES AL PROMEDIO");
        foreach (Libro libro in caso.GetMayorPromedio())
        {
            Console.WriteLine($"{libro.Id} - {libro.Titulo} - {libro.Precio:C}");
        }

        Console.WriteLine("\nORDENADOS DESCENDENTE");
        foreach (Libro libro in caso.GetOrdenadosPorTitulosDesc())
        {
            Console.WriteLine($"{libro.Id} - {libro.Titulo} - {libro.Precio:C}");
        }
    }
}

