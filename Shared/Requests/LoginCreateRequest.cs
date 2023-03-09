using System.ComponentModel.DataAnnotations;

namespace RentaCarBLAZOR.Shared.Requests;

public class LoginCreateRequest
{
    
    public int TablaVehiculoId  {get; set;} 

    [Range(1,int.MaxValue, ErrorMessage ="El Vehiculo seleccionado no es valido!.")]
   
    [
    Required (ErrorMessage="Se debe proporcionar el nombre del cliente"), 
    MinLength(3, ErrorMessage ="El nombre debe de superar los 3 caracteres"),
    MaxLength(100,ErrorMessage ="El nombre no debe superar los 100 caracteres")
    ]
        public string Name {get; set;} = null!;



    [
    Required (ErrorMessage="Se debe proporcionar el nickname del cliente"), 
    MinLength(3, ErrorMessage ="El nickname debe de superar los 3 caracteres"),
    MaxLength(100,ErrorMessage ="El nickname no debe superar los 100 caracteres")
    ]
    public string NikeName {get; set;} = null!;


[
    Required (ErrorMessage="Se debe proporcionar una contraseña"), 
    MinLength(3, ErrorMessage ="La contraseña debe de superar los 6 caracteres"),
    MaxLength(100,ErrorMessage ="El nickname no debe superar los 60 caracteres")
    ]
    public string NikePassword {get; set;} = null!;
}

public class LoginUpdateRequest : LoginCreateRequest
{
     [Required(ErrorMessage ="Se debe Proporcionar el Id del rol a modificar.")]
    public int Id {get; set;}

}