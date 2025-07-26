using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soccer_csharp;

public class Persona
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Origen { get; set; }
    public string? Email { get; set; }

    public Persona(int id, string? name, string? origen, string? email)
    {
        Id = id;
        Name = name;
        Origen = origen;
        Email = email;
    }
    public Persona() { }
}
