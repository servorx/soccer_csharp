using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using soccer_csharp.models;
using soccer_csharp.data;

namespace soccer_csharp.utils;

public class IdUtil
{
  // es static porque es una funcion que trabaja unicamente con valores no locales
  public int GenerarID()
  {
    // crear una instancia vacia de la clase random
    Random random = new Random();
    int nuevo_id = 0;
    do
    {
      nuevo_id = random.Next(1, 999);
      // el while es asi porque se verficia que no exista un id igual en todas las listas determinadas
      // TODO  Tener en cuenta que le coloque t? al AppData jugadores
    } while (AppData.Equipos.Any(t => t.Id == nuevo_id) || AppData.EstadisticaEquipos.Any(t => t.Id == nuevo_id) || AppData.EstadisticaJugadors.Any(t => t.Id == nuevo_id) || AppData.Jugadores.Any(t => t?.Id == nuevo_id) || AppData.Torneos.Any(t => t.Id == nuevo_id) || AppData.Transferencias.Any(t => t.Id == nuevo_id));
    // el Next devuelve un numero random no negativo con un numero maximo definido por su parametro, en este caso es entre 1 y 9999
    return nuevo_id;
  }
}