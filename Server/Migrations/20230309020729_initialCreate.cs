using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentaCarBLAZOR.Server.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TablaRentars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaSalida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaEntrega = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidosCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CedulaCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Crear = table.Column<bool>(type: "bit", nullable: false),
                    Editar = table.Column<bool>(type: "bit", nullable: false),
                    Eliminar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaRentars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablasClientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Crear = table.Column<bool>(type: "bit", nullable: false),
                    Editar = table.Column<bool>(type: "bit", nullable: false),
                    Eliminar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablasClientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablaVehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioRentar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Crear = table.Column<bool>(type: "bit", nullable: false),
                    Editar = table.Column<bool>(type: "bit", nullable: false),
                    Eliminar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaVehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TablaVehiculoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TablaVehiculoId1 = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NikeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NikePassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logins_TablaVehiculos_TablaVehiculoId1",
                        column: x => x.TablaVehiculoId1,
                        principalTable: "TablaVehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Logins_TablaVehiculoId1",
                table: "Logins",
                column: "TablaVehiculoId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "TablaRentars");

            migrationBuilder.DropTable(
                name: "TablasClientes");

            migrationBuilder.DropTable(
                name: "TablaVehiculos");
        }
    }
}
