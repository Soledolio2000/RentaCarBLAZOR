using System.ComponentModel.DataAnnotations;

namespace RentaCarBLAZOR.Shared.Requests;

public class TablaRentarUpdateRequest : TablaRentarCreateRequest 
{
     [Required(ErrorMessage ="Se debe Proporcionar el Id de al renta a modificar.")]
     public int Id {get; set;}
}
