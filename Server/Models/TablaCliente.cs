using System.ComponentModel.DataAnnotations;

namespace RentaCarBLAZOR.Server.Models;


public class TablaCliente
{
    [Key]
            public int Id {get; set;}
            public int  Cedula {get; set;}
            public string Nombre {get; set;} = null!;
            public string Apellidos {get; set;} = null!;
            public string Sexo {get; set;} = null!;
            public int Telefono {get; set;}
            public string Ciudad {get; set;} = null!;
            public string Direccion {get; set;} = null!;

    public bool Crear {get; set;}
    public bool Editar {get; set;}
    public bool Eliminar {get; set;}
}