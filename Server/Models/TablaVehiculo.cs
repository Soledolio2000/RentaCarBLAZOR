using System.ComponentModel.DataAnnotations;
using RentaCarBLAZOR.Shared.Records;
using RentaCarBLAZOR.Shared.Requests;

namespace RentaCarBLAZOR.Server.Models;


public class TablaVehiculo
{
    [Key]
            public int Id {get; set;}
            public int Matricula {get; set;}
            public string Marca {get; set;} = null!;
            public string Modelos {get; set;} = null!;
            public string Color {get; set;} = null!;
            public int PrecioRentar {get; set;}

    public bool permisoparacrear {get; set;}
    public bool permisoparaeditar {get; set;}
    public bool permisoparaeliminar {get; set;}

    public static TablaVehiculo Crear(TablaVehiculoCreateRequest request)
    {
        return new TablaVehiculo()
        {
            Matricula = request.Matricula,
            Marca = request.Marca,
            Modelos = request.Modelos,
            Color = request.Color,
            PrecioRentar = request.PrecioRentar,
            permisoparacrear = request.permisoparacrear,
            permisoparaeditar = request.permisoparaeditar,
            permisoparaeliminar = request.permisoparaeliminar
        };
    }

    public void Modificar(TablaVehiculoUpdateRequest request)
    {
        if(Matricula != request.Matricula)
            Matricula = request.Matricula;

        if(Marca != request.Marca)
            Marca = request.Marca;

        if(Modelos != request.Modelos)
            Modelos = request.Modelos;

        if(Color != request.Color)
            Color = request.Color;

        if(PrecioRentar != request.PrecioRentar)
            PrecioRentar = request.PrecioRentar;

        if(permisoparacrear != request.permisoparacrear)
            permisoparacrear = request.permisoparacrear;

        if(permisoparaeditar != request.permisoparaeditar)
            permisoparaeditar = request.permisoparaeditar;

        if(permisoparaeliminar != request.permisoparaeliminar)
            permisoparaeliminar = request.permisoparaeliminar;                                                                                    
    }

///Este es el retorno del constructor de las variables que se creo en el TablaVehiculoRecord a la TablaVehiculo, uno solo hace referencia a los mismos y los trae aqui.
    public TablaVehiculoRecord ToRecord()
    {
     return new TablaVehiculoRecord(
        Id,
        Matricula,
        Marca,
        Modelos,
        Color,
        PrecioRentar,
        permisoparacrear,
        permisoparaeditar,
        permisoparaeliminar);  
    }


}