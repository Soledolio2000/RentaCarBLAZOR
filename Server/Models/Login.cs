using System.ComponentModel.DataAnnotations;

namespace RentaCarBLAZOR.Server.Models;


public class Login
{
    [Key]
            public int Id {get; set;}
            public int TablaVehiculoId  {get; set;} 
            public virtual TablaVehiculo TablaVehiculo {get; set;} = null!;
            public string Name {get; set;} = null!;
            public string NikeName {get; set;} = null!;
            public string NikePassword {get; set;} = null!;

            

}