using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace soccer_csharp;

public class TorneoService
{
  public int Id { get; set; }
  public string? Nombre { get; set; }
  public string? FechaCreacion { get; set; }
  public int DuracionDias { get; set; }
  public float Premio { get; set; }
  public TorneoService(int id, string? nombre, string? fecha_creacion, int duracion_dias, float premio)
  {
    Nombre = nombre;
    FechaCreacion = fecha_creacion;
    DuracionDias = duracion_dias;
    Premio = premio;
  }
  public TorneoService() { }
  public static TorneoService CrearTorneo()
  {
    try
    {
      
    }
    catch (System.Exception)
    {
      
      throw;
    }
    Console.Write("Ingrese el nombre del torneo: ");
    Nombre = Console.ReadLine();
    return new Torneo(Nombre);
  }
  public void BuscarTorneo()
  {

  }
  public void EliminarTorneo()
  {

  }
  public void ActualizarTorneo()
  { 
    
  }
}
