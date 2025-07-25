using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soccer_csharp;

public class MenuEquipos
{
  public void MostrarMenuEquipos()
  {
    Console.Clear();
    Console.WriteLine("========== MENÚ EQUIPOS ==========\n");
    Console.WriteLine("1.1. Registrar equipo");
    Console.WriteLine("1.2. Registrar cuerpo tecnico");
    Console.WriteLine("1.3. Registrar cuerpo medico");
    Console.WriteLine("1.4. Inscricpion torneo");
    Console.WriteLine("1.5. Gestionar jugadores por equipo");
    Console.WriteLine("1.6. Notificacion de transferencia");
    Console.WriteLine("1.7. Salir del torneo");
    Console.WriteLine("1.8. Regresar al main menu\n");
    Console.Write("Selecciona una opción: ");
  }
  public void Mostrar()
  {
    bool validation_program = true;
    do
    {
      MostrarMenuEquipos();
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
          break;
        case "6":
          break;
        case "7":
          break;
        case "8":
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
