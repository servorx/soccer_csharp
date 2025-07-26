using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soccer_csharp;

public class MenuTorneos
{
  public void MostrarMenuTorneos()
  {
    Console.Clear();
    Console.WriteLine("========== MENÚ TORNEOS ==========\n");
    Console.WriteLine("0.1. Crear torneo");
    Console.WriteLine("0.2. Buscar torneo");
    Console.WriteLine("0.3. Eliminar torneo");
    Console.WriteLine("0.4. actualizar torneo");
    Console.WriteLine("0.5. Regresar al main menu\n");
    Console.Write("Selecciona una opción: ");
  }
  public void Mostrar()
  {
    bool validation_program = true;
    do
    {
      MostrarMenuTorneos();
      string? opcion = Console.ReadLine();
      switch (opcion)
      {
        case "1":
          TorneoService torneoService = new TorneoService();
          TorneoService.CrearTorneo();
          break;
        case "2":
          TorneoService equipoService1 = new TorneoService();
          equipoService1.BuscarTorneo();
          break;
        case "3":
          TorneoService equipoService2 = new TorneoService();
          equipoService2.EliminarTorneo();
          break;
        case "4":
          TorneoService equipoService3 = new TorneoService();
          equipoService3.ActualizarTorneo();
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
