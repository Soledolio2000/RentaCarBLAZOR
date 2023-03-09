using System.ComponentModel.DataAnnotations;

namespace Rent_A_Car2023.Server.Models;


public class TablaVehiculo
{
    [Key]
            public int Id {get; set;}
            public string Matricula {get; set;} = null!;
            public string Marca {get; set;} = null!;
            public string Modelos {get; set;} = null!;
            public string Color {get; set;} = null!;
            public string PrecioRentar {get; set;} = null!;

    public bool Crear {get; set;}
    public bool Editar {get; set;}
    public bool Eliminar {get; set;}
}