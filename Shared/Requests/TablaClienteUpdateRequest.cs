using System.ComponentModel.DataAnnotations;

namespace RentaCarBLAZOR.Shared.Requests;

public class TablaClienteUpdateRequest : TablaClienteCreateRequest
{
    [Required(ErrorMessage ="Se debe Proporcionar el Id del cliente a modificar.")]
            public int Id {get; set;}

}


