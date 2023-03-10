namespace RentaCarBLAZOR.Shared.Routes;

public class RouteApiBase
{
    public const string API = "/api";
    public int Id { get; set; }
    public const string IdParameter = "{Id:int}";//voy a esperar un valor entero de nombre Id//

    
}

public class TablaClienteRouteManager: RouteApiBase
{
    private const string Base = $"{API}/cliente";
    public const string GetById = $"{Base}/{IdParameter}";//  /api/cliente/{Id:int}// osea el Id no se generara automatico, si no que se lo estoy asignando//
    public static string BuildRoute(int Id) => GetById.Replace(IdParameter,Id.ToString());
}
public class TablaRentarRouteManager: RouteApiBase
{
    private const string Base = $"{API}/rentar";
    public const string GetById = $"{Base}/{IdParameter}";//  /api/cliente/{Id:int}// osea el Id no se generara automatico, si no que se lo estoy asignando//
    public static string BuildRoute(int Id) => GetById.Replace(IdParameter,Id.ToString());
}
public class TablaVehiculosRouteManager: RouteApiBase
{
    private const string Base = $"{API}/vehiculo";
    public const string GetById = $"{Base}/{IdParameter}";//  /api/cliente/{Id:int}// osea el Id no se generara automatico, si no que se lo estoy asignando//
    public static string BuildRoute(int Id) => GetById.Replace(IdParameter,Id.ToString());
}