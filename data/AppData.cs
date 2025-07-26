using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace soccer_csharp;

// se usa static porque no necesito crear instancias de la clase AppData.
public static class AppData
{
  // se crea una nueva lista vacia para poder agregar elementos desde las funciones principales en la carpeta servicios
  public static List<Equipo> Equipos { get; set; } = new();
  public static List<Estadistica> Estadisticas { get; set; } = new();
  public static List<Jugador> Jugadores { get; set; } = new();
  public static List<Torneo> Torneos { get; set; } = new();
  public static List<Transferencia> Transferencias { get; set; } = new();
}
