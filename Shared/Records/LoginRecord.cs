namespace RentaCarBLAZOR.Shared.Records;

public class LoginRecord
{
        public LoginRecord()
        {
                
        }
    public LoginRecord(int id, TablaVehiculoRecord tablaVehiculo, string name, string nikeName, string nikePassword)
    {
        Id = id;
        TablaVehiculo = tablaVehiculo;
        Name = name;
        NikeName = nikeName;
        NikePassword = nikePassword;
    }

    public int Id {get; set;}
        public virtual TablaVehiculoRecord TablaVehiculo {get; set;} = null!;
        public string Name {get; set;} = null!;
        public string NikeName {get; set;} = null!;
        public string NikePassword {get; set;} = null!;
}