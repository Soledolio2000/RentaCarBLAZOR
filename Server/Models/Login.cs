using System.ComponentModel.DataAnnotations;
using RentaCarBLAZOR.Shared.Records;
using RentaCarBLAZOR.Shared.Requests;

namespace RentaCarBLAZOR.Server.Models;


public class Login
{
    public Login()
    {
        
    }
    public Login(int tablaVehiculoId, string name, string nikeName, string nikePassword)
    {
        TablaVehiculoId = tablaVehiculoId;
        Name = name;
        NikeName = nikeName;
        NikePassword = nikePassword;
    }

    [Key]
            public int Id {get; set;}
            public int TablaVehiculoId  {get; set;} 
            public string Name {get; set;} = null!;
            public string NikeName {get; set;} = null!;
            public string NikePassword {get; set;} = null!;
            public virtual TablaVehiculo TablaVehiculo {get; set;} = null!;

    public static Login Crear(LoginCreateRequest request)
    {
        return new Login(request.TablaVehiculoId,request.Name,request.NikeName,request.NikePassword);
    }

    public void Modificar(LoginUpdateRequest request)
    {
        if(TablaVehiculoId != request.TablaVehiculoId) 
            TablaVehiculoId = request.TablaVehiculoId;
        if(Name != request.Name) 
            Name = request.Name;
        if(NikeName != request.NikeName) 
            NikeName = request.NikeName;
        if(NikePassword != request.NikePassword)    NikePassword = request.NikePassword;
    }

    public LoginRecord ToRecord()
    {
        return new LoginRecord(Id,TablaVehiculo.ToRecord(),Name,NikeName,NikePassword);
    }

}