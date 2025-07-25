using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Threading;

namespace soccer_csharp;

public class MenuPrincipal
{
  public void MostrarBienvenida()
  {
    Console.Clear();
    Console.WriteLine("======================================");
    Console.WriteLine("⚽ BIENVENIDO AL SISTEMA DE FÚTBOL ⚽");
    Console.WriteLine("======================================\n");
    Console.WriteLine("Este sistema permite gestionar torneos, equipos, jugadores,");
    Console.WriteLine("transferencias y estadísticas de manera interactiva.");
    Console.WriteLine("Desarrollado por Ángel Pinzón 🧠💻\n");
    Console.WriteLine("Presiona una tecla para continuar...");
    Console.ReadKey();
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
          System.Console.WriteLine("Gracias por usar nuestro programa!!");
          Console.ReadLine();
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
