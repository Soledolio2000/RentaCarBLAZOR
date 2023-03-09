using Microsoft.EntityFrameworkCore;
namespace RentaCarBLAZOR.Server.Context;
using RentaCarBLAZOR.Server.Models;

public interface IMyBDRentaCar
{
    DbSet<Login> Logins { get; set; }
    DbSet<TablaCliente> TablasClientes { get; set; }
    DbSet<TablaRentar> TablaRentars { get; set; }
    DbSet<TablaVehiculo> TablaVehiculos { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

public class MyBDRentaCar : DbContext, IMyBDRentaCar
{
    private readonly IConfiguration config;

    public MyBDRentaCar(IConfiguration _config)
    {
        config = _config;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {
        optionsBuilder.UseSqlServer(config.GetConnectionString("BDRentaCar"));
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
    #region Tabla de mis base de datos
    public DbSet<Login> Logins { set; get; } = null!;
    public DbSet<TablaCliente> TablasClientes { set; get; } = null!;
    public DbSet<TablaRentar> TablaRentars { set; get; } = null!;
    public DbSet<TablaVehiculo> TablaVehiculos { set; get; } = null!;
    #endregion

}