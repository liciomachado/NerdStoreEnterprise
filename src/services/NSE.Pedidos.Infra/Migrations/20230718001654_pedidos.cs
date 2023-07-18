using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NSE.Pedidos.Infra.Migrations
{
    public partial class pedidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "MinhaSequencia");

            migrationBuilder.AlterColumn<int>(
                name: "Codigo",
                table: "Pedidos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR MinhaSequencia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "MinhaSequencia",
                startValue: 1000L);

            migrationBuilder.AlterColumn<int>(
                name: "Codigo",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR MinhaSequencia",
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
