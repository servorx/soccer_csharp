using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soccer_csharp.models;

public class Jugador : Persona
{
  public string? Posicion { get; set; }
  public int NumeroDorsal { get; set; }
  public string? PieHabil { get; set; }
  public float ValorMercado { get; set; }
  public string? EquipoActual { get; set; }
  // composicion de estadisticas por jugador
  public List<EstadisticaJugador?> EstadisticaJugadores { get; set; } = new();
  public Jugador(int id, string? nombre, string? apellido, int edad, string? nacionalidad, int documento_identidad, string? genero,
    string? posicion, int numeroDorsal, string? pieHabil, float valorMercado, string? equipoActual, List<EstadisticaJugador?> estadisticaJugadores)
    : base(id, nombre, apellido, edad, nacionalidad, documento_identidad, genero)
  {
    // Atributos especificos de Jugador 
    Posicion = posicion;
    NumeroDorsal = numeroDorsal;
    PieHabil = pieHabil;
    ValorMercado = valorMercado;
    EquipoActual = equipoActual;
    EstadisticaJugadores = estadisticaJugadores;
  }
  public Jugador() { }
  public override string ToString()
  {
    return $"{Nombre} {Apellido} - {Posicion} (Dorsal: {NumeroDorsal}, Valor: {ValorMercado})";
  }
}
