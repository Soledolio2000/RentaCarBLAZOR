using System.ComponentModel.DataAnnotations;

namespace RentaCarBLAZOR.Server.Models;


public class TablaRentar
{
    [Key]
            public int Id {get; set;}
            public int Matricula {get; set;}
            public string FechaSalida {get; set;} = null!;
            public string FechaEntrega {get; set;} = null!;
            public string NombreCliente {get; set;} = null!;
            public string ApellidosCliente {get; set;} = null!;
            public int CedulaCliente {get; set;}
            public int TelefonoCliente {get; set;}

    public bool Crear {get; set;}
    public bool Editar {get; set;}
    public bool Eliminar {get; set;}
}