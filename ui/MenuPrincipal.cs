using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Threading;
using MySql.Data.MySqlClient;

namespace soccer_csharp;

public class MenuPrincipal
{
  public void MostrarBienvenida()
  {
      Console.Clear();

      EscribirConPausa("======================================", 100);
      EscribirConPausa("⚽ BIENVENIDO AL SISTEMA DE FÚTBOL ⚽", 100);
      EscribirConPausa("======================================\n", 100);

      Thread.Sleep(400);

      EscribirConPausa("Este sistema permite gestionar:", 100);
      EscribirConPausa("- Torneos",100);
      EscribirConPausa("- Equipos",100);
      EscribirConPausa("- Jugadores",100);
      EscribirConPausa("- Transferencias",100);
      EscribirConPausa("- Estadísticas",100);
      Console.WriteLine(); 

      Thread.Sleep(500);
      EscribirConPausa("De forma totalmente interactiva ⚙️ 🧠\n", 100);

      Thread.Sleep(500);
      EscribirConPausa("Desarrollado por Ángel Pinzón 🧠💻\n", 100);

      Thread.Sleep(700);
      Console.ForegroundColor = ConsoleColor.Yellow;
      EscribirConPausa("Presiona una tecla para continuar...", 100);
      Console.ResetColor();
      Console.ReadKey();
  }
  // Método auxiliar para escribir línea por línea con pausa.
  public void EscribirConPausa(string texto, int milisegundos)
  {
      Console.WriteLine(texto);
      Thread.Sleep(milisegundos);
  }
  public void MostrarMenuPrincipal()
  {
    Console.Clear();
    Console.WriteLine("========== MENÚ PRINCIPAL ==========\n");
    Console.WriteLine("0. Torneos");
    Console.WriteLine("1. Equipos");
    Console.WriteLine("2. Jugadores");
    Console.WriteLine("3. Transferencias");
    Console.WriteLine("4. Estadisticas");
    Console.WriteLine("5. Salir\n");
    Console.Write("Selecciona una opción: ");
  }
  public void EjecutarMenuMain()
  {
    bool validation_program = true;
    do
    {
      MostrarMenuPrincipal();
      string? opcion = (Console.ReadLine());

      switch (opcion)
      {
        case "0":
          MenuTorneos menuTorneos = new MenuTorneos();
          menuTorneos.Mostrar();
          break;
        case "1":
          MenuEquipos menuEquipos = new MenuEquipos();
          menuEquipos.Mostrar();
          break;
        case "2":
          MenuJugadores menuJugadores = new MenuJugadores();
          menuJugadores.Mostrar();
          break;
        case "3":
          MenuTransferencias menuTransferencias = new MenuTransferencias();
          menuTransferencias.Mostrar();
          break;
        case "4":
          MenuEstadisticas menuEstadisticas = new MenuEstadisticas();
          menuEstadisticas.Mostrar();
          break;
        case "5":
          validation_program = false;
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.WriteLine("==========================================");
          Console.WriteLine("     🙌 ¡GRACIAS POR USAR EL SISTEMA! 🙌");
          Console.WriteLine("==========================================\n");
          Console.ResetColor();

          Console.WriteLine("Esperamos que tu experiencia haya sido excelente. ⚽💻");
          Console.WriteLine("\n¡Jholver coloqueme buena nota porfa 🙏!");
          Console.WriteLine("\nPresiona cualquier tecla para salir...");
          Console.ReadKey();
          break;
        default:
          Console.Clear();
          System.Console.WriteLine("error al ingresar dato, intentelo de nuevo");
          Console.ReadLine();
          break;
      }
    } while (validation_program);
  }
}
