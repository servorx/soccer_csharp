using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soccer_csharp;

public class MenuEstadisticas
{
  public void MostrarMenuEstadisticas()
  {
    Console.Clear();
    Console.WriteLine("========== MENÚ ESTADISTICAS ==========\n");
    Console.WriteLine("4.1. Jugadores con mas asistencias por torneo ");
    Console.WriteLine("4.2. Equipos con mas goles en contra por torneo");
    Console.WriteLine("4.3. Jugadores mas caros por equipo");
    Console.WriteLine("4.4. Jugadores con edad mayor al promedio de edad del equipo");
    Console.WriteLine("4.5. Regresar al main menu\n");
    Console.Write("Selecciona una opción: ");
  }
  public void Mostrar()
  {
    bool validation_program = true;
    do
    {
      MostrarMenuEstadisticas();
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
