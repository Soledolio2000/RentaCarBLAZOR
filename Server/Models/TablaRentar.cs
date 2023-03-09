using System.ComponentModel.DataAnnotations;
using RentaCarBLAZOR.Shared.Records;
using RentaCarBLAZOR.Shared.Requests;

namespace RentaCarBLAZOR.Server.Models;


public class TablaRentar
{
    [Key]
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

public static TablaRentar Crear(TablaRentarCreateRequest request)
{
    return new TablaRentar()
    {
        Matricula = request.Matricula,
        FechaSalida = request.FechaSalida,
        FechaEntrega = request.FechaEntrega,
        NombreCliente = request.NombreCliente,
        ApellidosCliente = request.ApellidosCliente,
        CedulaCliente = request.CedulaCliente,
        TelefonoCliente = request.TelefonoCliente,

    };
}


public void Modificar(TablaRentarUpdateRequest request)
{
    if( Matricula != request.Matricula)
        Matricula  = request.Matricula;

    if( FechaSalida != request.FechaSalida)
        FechaSalida  = request.FechaSalida;

    if(FechaEntrega  != request.FechaEntrega)
        FechaEntrega  = request.FechaEntrega;

    if(NombreCliente  != request.NombreCliente)
        NombreCliente  = request.NombreCliente;

    if(ApellidosCliente  != request.ApellidosCliente)
        ApellidosCliente  = request.ApellidosCliente;

    if(CedulaCliente  != request.CedulaCliente)
        CedulaCliente  = request.CedulaCliente;

    if(TelefonoCliente  != request.TelefonoCliente)
        TelefonoCliente  = request.TelefonoCliente;                                       
}

///Este es el retorno del constructor de las variables que se creo en la TablaRentarRecord a la TablaRentar, uno solo hace referencia a los mismos y los trae aqui.
public TablaRentarRecord ToRecord()
{
    return new TablaRentarRecord(
        Id,
        Matricula,
        FechaSalida,
        FechaEntrega,
        NombreCliente,
        ApellidosCliente,
        CedulaCliente,
        TelefonoCliente,
        permisoparacrear,
        permisoparaeditar,
        permisoparaeliminar);
}

}



