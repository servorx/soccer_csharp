using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace admin_torneos2.Models.torneos;

public class Torneo
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? FechaCreacion { get; set; }
    public int Duracion { get; set; }
    public decimal Premio { get; set; }
    public Torneo(int id, string? name, string? fechacreacion, int duracion, decimal premio)
    {
        Id = id;
        Name = name;
        FechaCreacion = fechacreacion;
        Duracion = duracion;
        Premio = premio;
    }
    public Torneo() { }
    public override string ToString()
    {
        return $"Nombre del torneo: {Name},\nId: {Id}\nfecha de inicio: {FechaCreacion},\nsemanas que dura el torneo: {Duracion}semanas,\nPremio para el 1er lugar: {Premio}\n";
    }
    public static Torneo Addtorneo()
    {
        Console.WriteLine("Ingrese un Id:");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("¡Error! Ingresa un número válido.");
            return Addtorneo();
        }

        Console.WriteLine("Ingrese el nombre del torneo:");
        string? nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la fecha de inicio del torneo:");
        string? fechaCreacion = Console.ReadLine();

        Console.WriteLine("Ingrese cuántas semanas durará el torneo:");
        if (!int.TryParse(Console.ReadLine(), out int duracion))
        {
            Console.WriteLine("¡Error! Ingresa un número válido.");
            return Addtorneo();
        }

        Console.WriteLine("Ingrese el premio del torneo:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal premio))
        {
            Console.WriteLine("¡Error! Ingresa un valor monetario válido.");
            return Addtorneo();
        }

        return new Torneo(id, nombre, fechaCreacion, duracion, premio);
    }
    // public static Torneo Addtorneo()
    // {
    //     Console.WriteLine("Ingrese el nombre del torneo:");
    //     string? nombre = Console.ReadLine();

    //     Console.WriteLine("Ingrese la fecha de inicio del torneo:");
    //     string? fechaCreacion = Console.ReadLine();

    //     Console.WriteLine("Ingrese cuántas semanas durará el torneo:");
    //     if (!int.TryParse(Console.ReadLine(), out int duracion))
    //     {
    //         Console.WriteLine("¡Error! Ingresa un número válido.");
    //         return Addtorneo();
    //     }

    //     Console.WriteLine("Ingrese el premio del torneo:");
    //     if (!decimal.TryParse(Console.ReadLine(), out decimal premio))
    //     {
    //         Console.WriteLine("¡Error! Ingresa un valor monetario válido.");
    //         return Addtorneo();
    //     }

    //     return new Torneo(nombre, fechaCreacion, duracion, premio);
    // }
}