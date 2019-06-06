using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.Migrations
{
    public partial class change1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Devices_DeviceId1",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_DeviceId1",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "DeviceId1",
                table: "Devices");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeviceId1",
                table: "Devices",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Devices_DeviceId1",
                table: "Devices",
                column: "DeviceId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Devices_DeviceId1",
                table: "Devices",
                column: "DeviceId1",
                principalTable: "Devices",
                principalColumn: "DeviceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
