using System.ComponentModel.DataAnnotations;

namespace RentaCarBLAZOR.Shared.Requests;

public class TablaVehiculoUpdateRequest : TablaVehiculoCreateRequest
{
    [Required(ErrorMessage ="Se debe Proporcionar el Id del vehiculo a modificar.")]
    public int Id {get; set;}
}