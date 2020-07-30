using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminUI.Date.Migrations
{
    public partial class up : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.CreateTable(
                name: "mstbstate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ip_Address = table.Column<string>(nullable: true),
                    Channel1 = table.Column<string>(nullable: true),
                    Channel2 = table.Column<string>(nullable: true),
                    Temperature = table.Column<string>(nullable: true),
                    Humidity = table.Column<string>(nullable: true),
                    Monitor_Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mstbstate", x => x.Id);
                });

      
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mstb_monitorcurrent");

            migrationBuilder.DropTable(
                name: "mstb_monitorhistory");

            migrationBuilder.DropTable(
                name: "mstb_monitorstate");

            migrationBuilder.DropTable(
                name: "mstbstate");

            migrationBuilder.DropTable(
                name: "Sys_Area");

            migrationBuilder.DropTable(
                name: "Sys_DbBackup");

            migrationBuilder.DropTable(
                name: "Sys_FilterIP");

            migrationBuilder.DropTable(
                name: "Sys_Items");

            migrationBuilder.DropTable(
                name: "Sys_ItemsDetail");

            migrationBuilder.DropTable(
                name: "Sys_Log");

            migrationBuilder.DropTable(
                name: "Sys_Module");

            migrationBuilder.DropTable(
                name: "Sys_ModuleButton");

            migrationBuilder.DropTable(
                name: "Sys_ModuleForm");

            migrationBuilder.DropTable(
                name: "Sys_ModuleFormInstance");

            migrationBuilder.DropTable(
                name: "Sys_Organize");

            migrationBuilder.DropTable(
                name: "Sys_Role");

            migrationBuilder.DropTable(
                name: "Sys_RoleAuthorize");

            migrationBuilder.DropTable(
                name: "Sys_User");

            migrationBuilder.DropTable(
                name: "Sys_UserLogOn");
        }
    }
}
