using System.ComponentModel.DataAnnotations;

namespace RentaCarBLAZOR.Server.Models;


public class TablaVehiculo
{
    [Key]
            public int Id {get; set;}
            public int Matricula {get; set;}
            public string Marca {get; set;} = null!;
            public string Modelos {get; set;} = null!;
            public string Color {get; set;} = null!;
            public int PrecioRentar {get; set;}

    public bool Crear {get; set;}
    public bool Editar {get; set;}
    public bool Eliminar {get; set;}
}