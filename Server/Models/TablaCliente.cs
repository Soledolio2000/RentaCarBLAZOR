using System.ComponentModel.DataAnnotations;

namespace Rent_A_Car2023.Server.Models;


public class TablaCliente
{
    [Key]
            public int Id {get; set;}
            public string Cedula {get; set;} = null!;
            public string Nombre {get; set;} = null!;
            public string Apellidos {get; set;} = null!;
            public string Sexo {get; set;} = null!;
            public string Telefono {get; set;} = null!;
            public string Ciudad {get; set;} = null!;
            public string Direccion {get; set;} = null!;

    public bool Crear {get; set;}
    public bool Editar {get; set;}
    public bool Eliminar {get; set;}
}