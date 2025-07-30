using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using soccer_csharp.data;
using soccer_csharp.models;
using soccer_csharp.utils;

namespace soccer_csharp.services;

public class EstadisticaService
{
  private readonly Validaciones validate_input = new();
  private readonly IdUtil id_util = new();
  public void CrearEstadisticasEquipo()
  {
    Console.Clear();
    Console.WriteLine("=== CREAR NUEVAS ESTADISTICAS DE EQUIPO ===");

    int id_nuevo = id_util.GenerarID();

    System.Console.WriteLine("Ingrese el ID del equipo: ");
    int? equipo_id = validate_input.ValidarEntero(Console.ReadLine());

    System.Console.WriteLine("ingrese la cantidad de partidos ganados: ");
    int partidos_ganados = validate_input.ValidarEntero(Console.ReadLine());

    System.Console.WriteLine("ingrese la cantidad de partidos empatados: ");
    int partidos_empatados = validate_input.ValidarEntero(Console.ReadLine());

    System.Console.WriteLine("ingrese la cantidad de partidos perdidos: ");
    int partidos_perdidos = validate_input.ValidarEntero(Console.ReadLine());

    System.Console.WriteLine("ingrese la cantidad de goles a favor: ");
    int goles_a_favor = validate_input.ValidarEntero(Console.ReadLine());
    
    System.Console.WriteLine("ingrese la cantidad de goles en contra: ");
    int goles_en_contra = validate_input.ValidarEntero(Console.ReadLine());

    System.Console.WriteLine("\nIngresaste los siguientes datos:");
    EstadisticaEquipo nueva_estadistica = new EstadisticaEquipo(id_nuevo, equipo_id, partidos_ganados, partidos_empatados, partidos_perdidos, goles_a_favor, goles_en_contra);
    nueva_estadistica.MostrarResumen();
    // validar la entrada de datos por el usuario
    System.Console.Write("deseas confirmar los cambios? (s/n): ");
    bool validate_data = validate_input.ValidarBoleano(Console.ReadLine());

    // agregar los datos a la lista EstadisticaJugador
    if (validate_data)
    {
      AppData.EstadisticaEquipos.Add(nueva_estadistica);
      Console.Clear();
      System.Console.WriteLine("Estadistica de Equipo creada exitosamente :)");
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
  public void CrearEstadisticasJugador()
  {
    Console.Clear();
    Console.WriteLine("=== CREAR NUEVAS ESTADISTICAS DE JUGADOR ===");

    int id_nuevo = id_util.GenerarID();

    // TODO: revisar como puedo obtener el ID del jugador
    System.Console.Write("Ingrese el nombre del jugador: ");
    string nombre = validate_input.ValidarTexto(Console.ReadLine()).ToLower();

    System.Console.WriteLine("ingrese los goles del jugador: ");
    int goles = validate_input.ValidarEntero(Console.ReadLine());

    System.Console.WriteLine("ingrese las asistencias del jugador: ");
    int asistencias = validate_input.ValidarEntero(Console.ReadLine());

    System.Console.WriteLine("ingrese la cantidad de partidos jugados por el jugador: ");
    int partidos_jugados = validate_input.ValidarEntero(Console.ReadLine());

    System.Console.WriteLine("ingrese la estatura del jugador (en metros): ");
    float estatura = validate_input.ValidarDecimal(Console.ReadLine());

    System.Console.WriteLine("ingrese el peso del jugador (en kilogramos): ");
    float peso = validate_input.ValidarDecimal(Console.ReadLine());

    System.Console.WriteLine("ingrese la cantidad de tarjetas amarillas del jugador: ");
    int tarjetas_amarillas = validate_input.ValidarEntero(Console.ReadLine());

    System.Console.WriteLine("ingrese la cantidad de tarjetas rojas del jugador: ");
    int tarjetas_rojas = validate_input.ValidarEntero(Console.ReadLine());

    System.Console.WriteLine("\nIngresaste los siguientes datos:");
    EstadisticaJugador nueva_estadistica = new EstadisticaJugador(id_nuevo, goles, asistencias, partidos_jugados, estatura, peso, tarjetas_amarillas, tarjetas_rojas);
    nueva_estadistica.MostrarResumen();
    // validar la entrada de datos por el usuario
    System.Console.Write("deseas confirmar los cambios? (s/n): ");
    bool validate_data = validate_input.ValidarBoleano(Console.ReadLine());

    // agregar los datos a la lista EstadisticaJugador
    if (validate_data)
    {
      AppData.EstadisticaJugadors.Add(nueva_estadistica);
      Console.Clear();
      System.Console.WriteLine("Estadistica de jugador creada exitosamente :)");
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
  public void JugadoresConMasAsistenciasPorTorneo()
  {
    // Implementación del método para obtener jugadores con más asistencias por torneo
  }
  public void EquiposConMasGolesEnContraPorTorneo()
  {
    // Implementación del método para obtener equipos con más goles en contra por torneo
  }
  public void JugadoresMasCarosPorEquipo()
  {

  }
  public void JugadoresConEdadMayorAlPromedioDeEdadDelEquipo()
  {
    // Implementación del método para obtener jugadores con edad mayor al promedio de edad del equipo
  }
}
