namespace RentaCarBLAZOR.Shared.Records;

public class TablaClienteRecord
{

    public TablaClienteRecord()
    {
        
    }
    public TablaClienteRecord(int id, string nombre, string apellidos, int cedula, string sexo, int telefono, string ciudad, string direccion, bool permisoparacrear, bool permisoparaeditar, bool permisoparaeliminar)
    {
        Id = id;
        Nombre = nombre;
        Apellidos = apellidos;
        Cedula = cedula;
        Sexo = sexo;
        Telefono = telefono;
        Ciudad = ciudad;
        Direccion = direccion;
        this.permisoparacrear = permisoparacrear;
        this.permisoparaeditar = permisoparaeditar;
        this.permisoparaeliminar = permisoparaeliminar;
    }

    public int Id {get; set;}
            public string Nombre {get; set;} = null!;
            public string Apellidos {get; set;} = null!;
            public int  Cedula {get; set;}
            public string Sexo {get; set;} = null!;
            public int Telefono {get; set;}
            public string Ciudad {get; set;} = null!;
            public string Direccion {get; set;} = null!;

    public bool permisoparacrear {get; set;}
    public bool permisoparaeditar {get; set;}
    public bool permisoparaeliminar {get; set;}
}
