using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soccer_csharp;

public class MenuJugadores
{
  public void MostrarMenuJugadores()
  {
    Console.Clear();
    Console.WriteLine("========== MENÚ JUGADORES ==========\n");
    Console.WriteLine("2.1. Registrar jugador");
    Console.WriteLine("2.2. Buscar jugador");
    Console.WriteLine("2.3. Editar jugador");
    Console.WriteLine("2.4. Eliminar jugador");
    Console.WriteLine("2.5. Regresar al main menu\n");
    Console.Write("Selecciona una opción: ");
  }
  public void Mostrar()
  {
    bool validation_program = true;
    do
    {
      MostrarMenuJugadores();
      string? opcion = Console.ReadLine();
      switch (opcion)
      {
        case "1":
          break;
        case "2":
          break;
        case "3":
          break;
        case "4":
          break;
        case "5":
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
