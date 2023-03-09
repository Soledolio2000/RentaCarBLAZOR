namespace RentaCarBLAZOR.Shared.Records;

public class TablaRentarRecord
{
    public TablaRentarRecord()
    {
        
    }
    public TablaRentarRecord(int id, int matricula, string fechaSalida, string fechaEntrega, string nombreCliente, string apellidosCliente, int cedulaCliente, int telefonoCliente, bool permisoparacrear, bool permisoparaeditar, bool permisoparaeliminar)
    {
        Id = id;
        Matricula = matricula;
        FechaSalida = fechaSalida;
        FechaEntrega = fechaEntrega;
        NombreCliente = nombreCliente;
        ApellidosCliente = apellidosCliente;
        CedulaCliente = cedulaCliente;
        TelefonoCliente = telefonoCliente;
        this.permisoparacrear = permisoparacrear;
        this.permisoparaeditar = permisoparaeditar;
        this.permisoparaeliminar = permisoparaeliminar;
    }

    public int Id {get; set;}
            public int Matricula {get; set;}
            public string FechaSalida {get; set;} = null!;
            public string FechaEntrega {get; set;} = null!;
            public string NombreCliente {get; set;} = null!;
            public string ApellidosCliente {get; set;} = null!;
            public int CedulaCliente {get; set;}
            public int TelefonoCliente {get; set;}

    public bool permisoparacrear {get; set;}
    public bool permisoparaeditar {get; set;}
    public bool permisoparaeliminar {get; set;}
}