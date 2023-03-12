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

using Respuesta = Result<TablaClienteRecord>;
using Request = TablaClienteRouteManager;


public class GetById : EndpointBaseAsync.WithRequest<Request>.WithActionResult<Respuesta>
{
    private readonly IMyBDRentaCar dbContext;

    public GetById(IMyBDRentaCar dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpGet(TablaClienteRouteManager.GetById)]    //OJO EL MAESTRO PUSO BASE DONDE YO PUSE API//
    public override async Task<ActionResult<Respuesta>> HandleAsync([FromRoute] Request request,CancellationToken cancellationToken = default)
    {
        try
        {
        var rol = await dbContext.TablasClientes
        .Where(r=>r.Id == request.Id)
        .Select(rol => rol.ToRecord())
        .FirstOrDefaultAsync(cancellationToken);

    if(rol==null)
        return Respuesta.Fail($"No fue posible encontrar el rol '{request.Id}' ");

        return Respuesta.Success(rol);
        }
        catch(Exception ex)
        {
        return Respuesta.Fail(ex.Message);
        }
    }
}


