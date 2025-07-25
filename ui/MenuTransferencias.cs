using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soccer_csharp;

public class MenuTransferencias
{
  public void MostrarMenuTransferencias()
  {
    Console.Clear();
    Console.WriteLine("========== MENÚ TRANSFERENCIAS ==========\n");
    Console.WriteLine("3.1. Crear torneo");
    Console.WriteLine("3.2. Buscar torneo");
    Console.WriteLine("3.3. Regresar al main menu\n");
    Console.Write("Selecciona una opción: ");
  }
  public void Mostrar()
  {
    bool validation_program = true;
    do
    {
      MostrarMenuTransferencias();
      string? opcion = Console.ReadLine();
      switch (opcion)
      {
        case "1":
          break;
        case "2":
          break;
        case "3":
          return;
        default:
          Console.Clear();
          System.Console.WriteLine("error al ingresar dato, intentelo de nuevo");
          Console.ReadLine();
          break;
      }
    } while (validation_program);
  }
}
