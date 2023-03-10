using System.Data.SqlTypes;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentaCarBLAZOR.Server.Context;
using RentaCarBLAZOR.Shared;
using RentaCarBLAZOR.Shared.Records;
using RentaCarBLAZOR.Shared.Routes;
using RentaCarBLAZOR.Shared.Wrapper;
namespace RentaCarBLAZOR.Server.Empoints.TablaClienteRoles;
using Respuesta = ResultList<TablaClienteRecord>;


public class Get : EndpointBaseAsync.WithoutRequest.WithActionResult<Respuesta>
{
    private readonly IMyBDRentaCar dbContext;

    public Get(IMyBDRentaCar dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpGet(TablaClienteRouteManager.BASE)]    //OJO EL MAESTRO PUSO BASE DONDE YO PUSE API//
    public override async Task<ActionResult<Respuesta>> HandleAsync(CancellationToken cancellationToken = default)
    {
        try
        {
        var roles = await dbContext.TablasClientes
        .Select(rol => rol.ToRecord())
        .ToListAsync(cancellationToken);

        return Respuesta.Success(roles);
        }
        catch(Exception ex)
        {
        return Respuesta.Fail(ex.Message);
        }
    }
}