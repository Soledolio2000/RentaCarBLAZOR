using System.ComponentModel.DataAnnotations;

namespace RentaCarBLAZOR.Shared.Requests;

public class TablaVehiculoCreateRequest
{
[
    Required (ErrorMessage="Se debe proporcionar el dato del vehiculo"), 
    MinLength(5, ErrorMessage ="El dato debe de superar los 5 caracteres"),
    MaxLength(100,ErrorMessage ="El dato no debe superar los 100 caracteres")
]
    public int Matricula {get; set;}
    public string Marca {get; set;} = null!;
    public string Modelos {get; set;} = null!;
    public string Color {get; set;} = null!;
    public int PrecioRentar {get; set;}

    public bool permisoparacrear {get; set;}
    public bool permisoparaeditar {get; set;}
    public bool permisoparaeliminar {get; set;}
}
