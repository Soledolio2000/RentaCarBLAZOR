using System.ComponentModel.DataAnnotations;

namespace Rent_A_Car2023.Server.Models;


public class TablaRentar
{
    [Key]
            public int Id {get; set;}
            public string Matricula {get; set;} = null!;
            public string FechaSalida {get; set;} = null!;
            public string FechaEntrega {get; set;} = null!;
            public string NombreCliente {get; set;} = null!;
            public string ApellidosCliente {get; set;} = null!;
            public string CedulaCliente {get; set;} = null!;
            public string TelefonoCliente {get; set;} = null!;

    public bool Crear {get; set;}
    public bool Editar {get; set;}
    public bool Eliminar {get; set;}
}