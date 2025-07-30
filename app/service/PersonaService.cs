using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using soccer_csharp.data;
using soccer_csharp.models;
using soccer_csharp.utils;

namespace soccer_csharp.services;
public class PersonaService
{
  private readonly Validaciones validate_input = new();
  private readonly IdUtil id_util = new();
  public void CrearPersona()
  {
    Console.Clear();
    Console.WriteLine("=== CREAR NUEVA PERSONA ===");

    int id_nuevo = id_util.GenerarID();

    System.Console.Write("Ingrese el nombre de la persona: ");
    string nombre = validate_input.ValidarTexto(Console.ReadLine()).ToLower();

    System.Console.Write("Ingrese el apellido de la persona: ");
    string apellido = validate_input.ValidarTexto(Console.ReadLine()).ToLower();

    System.Console.Write("ingrese la edad de la persona: ");
    int edad = validate_input.ValidarEntero(Console.ReadLine());

    System.Console.Write("ingrese la nacionalidad de la persona: ");
    string nacionalidad = validate_input.ValidarTexto(Console.ReadLine());

    System.Console.Write("ingrese el numero del documento de la persona: ");
    int documento_identidad = validate_input.ValidarEntero(Console.ReadLine());

    System.Console.Write("ingrese el genero de la persona: ");
    string genero = validate_input.ValidarTexto(Console.ReadLine());

    System.Console.WriteLine("\nIngresaste los siguientes datos:");
    Persona nueva_persona = new Persona(id_nuevo, nombre, apellido, edad, nacionalidad, documento_identidad, genero);
    nueva_persona.ToString();
    System.Console.WriteLine("deseas guardar los datos? (s/n): ");

    bool validate_data = validate_input.ValidarBoleano(Console.ReadLine());
    // agregar los datos a la lista de Personas
    if (validate_data)
    {
      AppData.Personas.Add(nueva_persona);
      Console.Clear();
      System.Console.WriteLine("Persona creada exitosamente :)");
      System.Console.WriteLine("presione una tecla para continuar...");
      Console.ReadLine();
    }
    else
    {
      Console.Clear();
      System.Console.WriteLine("no confirmó los cambios, presione una tecla para volver al menu");
      Console.ReadLine();
    }
  }
}
