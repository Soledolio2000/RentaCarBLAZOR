using System.ComponentModel.DataAnnotations;
using RentaCarBLAZOR.Shared.Records;
using RentaCarBLAZOR.Shared.Requests;

namespace RentaCarBLAZOR.Server.Models;


public class TablaCliente
{
    [Key]
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


    public static TablaCliente Crear(TablaClienteCreateRequest request)
    {
        return new TablaCliente() 
        {
            Nombre = request.Nombre,
            Apellidos = request.Apellidos,
            Cedula = request.Cedula,
            Sexo = request.Sexo,
            Telefono = request.Telefono,
            Ciudad = request.Ciudad,
            Direccion = request.Direccion,
            permisoparacrear = request.permisoparacrear,
            permisoparaeditar = request.permisoparaeditar,
            permisoparaeliminar = request.permisoparaeliminar,
        };
    }
    
    public void Modificar(TablaClienteUpdateRequest request)
    {
        if(Nombre != request.Nombre)
            Nombre = request.Nombre;

        if(Apellidos != request.Apellidos)
            Apellidos = request.Apellidos;

        if( Cedula!= request.Cedula)
            Cedula = request.Cedula;

        if(Sexo != request.Sexo)
            Sexo = request.Sexo;

        if(Telefono != request.Telefono)
            Telefono = request.Telefono; 

        if(Ciudad != request.Ciudad)
            Ciudad = request.Ciudad;

        if(Direccion != request.Direccion)
            Direccion = request.Direccion;

        if(permisoparacrear != request.permisoparacrear)
            permisoparacrear = request.permisoparacrear;

        if(permisoparaeditar != request.permisoparaeditar)
            permisoparaeditar = request.permisoparaeditar;

         if(permisoparaeliminar != request.permisoparaeliminar)
            permisoparaeliminar = request.permisoparaeliminar;

    }

///Este es el retorno del constructor de las variables que se creo en la TablaClienteRecord a la TablaCliente, uno solo hace referencia a los mismos y los trae aqui.
   public TablaClienteRecord ToRecord()
   {
      return new TablaClienteRecord(
        Id,
        Nombre,
        Apellidos,
        Cedula,
        Sexo,
        Telefono,
        Ciudad,
        Direccion,
        permisoparacrear,
        permisoparaeditar,
        permisoparaeliminar);
   }

}