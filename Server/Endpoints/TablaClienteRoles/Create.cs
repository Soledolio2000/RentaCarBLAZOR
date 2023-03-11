using System.Net;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using RentaCarBLAZOR.Server.Context;
using RentaCarBLAZOR.Shared.Requests;
using RentaCarBLAZOR.Shared.Wrapper;
using RentaCarBLAZOR.Server.Models;
using Microsoft.EntityFrameworkCore;
using RentaCarBLAZOR.Shared.Routes;

namespace RentaCarBLAZOR.Server.Empoints.TablaClienteRoles;

using Request = TablaClienteCreateRequest; 
using Respuesta = Result<int>;

public class Create : EndpointBaseAsync.WithRequest<Request>.WithActionResult<Respuesta>
{
    private readonly IMyBDRentaCar dbContext;

    public Create(IMyBDRentaCar dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpPost(TablaClienteRouteManager.BASE)]

    public override async Task<ActionResult<Respuesta>> HandleAsync(Request request, CancellationToken cancellationToken = default)
    {
        try 
        {
            #region Validaciones
            var rol = await dbContext.TablasClientes.FirstOrDefaultAsync(r => r.Nombre.ToLower() == request.Nombre.ToLower(),cancellationToken);
            if(rol != null)
                return Respuesta.Fail($"Ya existe un rol con el nombre '({request.Nombre})'.");
            #endregion
            rol = TablaCliente.Crear(request);
            dbContext.TablasClientes.Add(rol);
            await dbContext.SaveChangesAsync(cancellationToken);
            return Respuesta.Success(rol.Id);
        }
        
        catch(Exception e)
        {
            return Respuesta.Fail(e.Message);
        }
    }
}