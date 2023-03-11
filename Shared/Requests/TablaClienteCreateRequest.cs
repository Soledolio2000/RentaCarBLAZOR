using System.ComponentModel.DataAnnotations;

namespace RentaCarBLAZOR.Shared.Requests;

public class TablaClienteCreateRequest
{
    [
    Required (ErrorMessage="Se debe proporcionar el dato del cliente"), 
    MinLength(3, ErrorMessage ="El dato debe de superar los 3 caracteres"),
    MaxLength(100,ErrorMessage ="El dato no debe superar los 100 caracteres")
    ]
        public string Nombre {get; set;} = null!;
        public string Apellidos {get; set;} = null!;
        public int  Cedula {get; set;}
        public string Sexo {get; set;} = null!;
        public int Telefono {get; set;}
        public string Ciudad {get; set;} = null!;
        public string Direccion {get; set;} = null!;

    public bool permisoparacrear {get; set;}
    public bool permisoparaeditar {get; set;}
    public bool permisoparaeliminar {get; set;}

}


