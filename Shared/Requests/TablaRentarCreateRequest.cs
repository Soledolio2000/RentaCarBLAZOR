using System.ComponentModel.DataAnnotations;

namespace RentaCarBLAZOR.Shared.Requests;

public class TablaRentarCreateRequest 
{
    [
    Required (ErrorMessage="Se debe proporcionar el dato de la renta"), 
    MinLength(5, ErrorMessage ="El dato debe de superar los 5 caracteres"),
    MaxLength(100,ErrorMessage ="El dato no debe superar los 100 caracteres")
    ]
     public int Matricula {get; set;}
    public string FechaSalida {get; set;} = null!;
    public string FechaEntrega {get; set;} = null!;
    public string NombreCliente {get; set;} = null!;
    public string ApellidosCliente {get; set;} = null!;
    public int CedulaCliente {get; set;}
    public int TelefonoCliente {get; set;}

    public bool permisoparacrear {get; set;}
    public bool permisoparaeditar {get; set;}
    public bool permisoparaeliminar {get; set;}
}
