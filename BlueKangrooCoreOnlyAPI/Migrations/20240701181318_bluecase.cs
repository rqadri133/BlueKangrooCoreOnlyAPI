using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueKangrooCoreOnlyAPI.Migrations
{
    public partial class bluecase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AppRouteID",
                table: "AppDispatchAssigned",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "ItemCombinationJSON  NVARCHAR(MAX) NOT NULL,\r\n	[CreatedBy",
                table: "AppDispatch",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "AppDispatch",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "AppRoute",
                columns: table => new
                {
                    AppRouteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppRouteDesc = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    AppLocationStartID = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    AppLocationEndID = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoute");

            migrationBuilder.DropColumn(
                name: "AppRouteID",
                table: "AppDispatchAssigned");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AppDispatch");

            migrationBuilder.AlterColumn<Guid>(
                name: "ItemCombinationJSON  NVARCHAR(MAX) NOT NULL,\r\n	[CreatedBy",
                table: "AppDispatch",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
