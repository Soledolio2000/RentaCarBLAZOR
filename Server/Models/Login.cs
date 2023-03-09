using System.ComponentModel.DataAnnotations;

namespace Rent_A_Car2023.Server.Models;


public class Login
{
    [Key]
            public int Id {get; set;}
            public string TablaVehiculoId  {get; set;} = null!;
            public virtual TablaVehiculo TablaVehiculo {get; set;} = null!;
            public string Name {get; set;} = null!;
            public string NikeName {get; set;} = null!;
            public string NikePassword {get; set;} = null!;

            

}