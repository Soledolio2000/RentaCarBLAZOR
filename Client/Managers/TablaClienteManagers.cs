using RentaCarBLAZOR.Shared.Wrapper;
using RentaCarBLAZOR.Shared.Records;
using RentaCarBLAZOR.Shared.Routes;
using RentaCarBLAZOR.Client.Extensions;

namespace RentaCarBLAZOR.Client.Managers;

public interface ITablaClienteManager
{
    Task<ResultList<TablaClienteRecord>> GetAsync();
}

public class TablaClienteManager : ITablaClienteManager
{
    private readonly HttpClient httpClient;

    public TablaClienteManager(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<ResultList<TablaClienteRecord>> GetAsync()
    {
        try
        {
            var response = await httpClient.GetAsync(TablaClienteRouteManager.BASE);
            var resultado = await response.ToResultList<TablaClienteRecord>();
            return resultado;
        }

        catch (Exception ex)
        {
            return ResultList<TablaClienteRecord>.Fail(ex.Message);
        }

    }
}