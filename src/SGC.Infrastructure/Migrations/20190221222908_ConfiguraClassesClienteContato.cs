using Microsoft.EntityFrameworkCore.Migrations;

namespace SGC.Infrastructure.Migrations
{
    public partial class ConfiguraClassesClienteContato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Contato",
                type: "VARCHAR(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Contato",
                type: "VARCHAR(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contato",
                type: "VARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "VARCHAR(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Cliente",
                type: "VARCHAR(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Contato",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Contato",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contato",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(11)");
        }
    }
}
