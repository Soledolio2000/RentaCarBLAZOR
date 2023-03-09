namespace RentaCarBLAZOR.Shared.Records;

public class TablaVehiculoRecord 
{

    public TablaVehiculoRecord()
    {
        
    }
    public TablaVehiculoRecord(int id, int matricula, string marca, string modelos, string color, int precioRentar, bool permisoparacrear, bool permisoparaeditar, bool permisoparaeliminar)
    {
        Id = id;
        Matricula = matricula;
        Marca = marca;
        Modelos = modelos;
        Color = color;
        PrecioRentar = precioRentar;
        this.permisoparacrear = permisoparacrear;
        this.permisoparaeditar = permisoparaeditar;
        this.permisoparaeliminar = permisoparaeliminar;
    }

    public int Id {get; set;}
            public int Matricula {get; set;}
            public string Marca {get; set;} = null!;
            public string Modelos {get; set;} = null!;
            public string Color {get; set;} = null!;
            public int PrecioRentar {get; set;}

    public bool permisoparacrear {get; set;}
    public bool permisoparaeditar {get; set;}
    public bool permisoparaeliminar {get; set;}
}