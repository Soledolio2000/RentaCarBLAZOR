using RentaCarBLAZOR.Shared.Wrapper;
using RentaCarBLAZOR.Shared.Records;
using RentaCarBLAZOR.Shared.Routes;
using RentaCarBLAZOR.Shared.Requests;
using RentaCarBLAZOR.Client.Extensions;
using System.Net.Http.Json;

namespace RentaCarBLAZOR.Client.Managers;

public interface ITablaClienteManager
{
    Task<ResultList<TablaClienteRecord>> GetAsync();
    Task<Result<int>> CreateAsync(TablaClienteCreateRequest request);
    Task<Result<TablaClienteRecord>> CreateAsync(int Id);
    
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
    public async Task<Result<int>> CreateAsync(TablaClienteCreateRequest request)
    {
        var response = await httpClient.PostAsJsonAsync(TablaClienteRouteManager.BASE,request);
        return await response.ToResult<int>();
    }
     public async Task<Result<TablaClienteRecord>> CreateAsync(int Id)
    {
        var response = await httpClient.GetAsync(TablaClienteRouteManager.BuildRoute(Id));
        return await response.ToResult<TablaClienteRecord>();
    }

}