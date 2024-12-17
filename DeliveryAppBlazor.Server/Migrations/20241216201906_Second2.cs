using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliveryAppBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class Second2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Updated",
                table: "Orders",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Orders",
                newName: "DataCreated");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Orders",
                newName: "Updated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Orders",
                newName: "Created");
        }
    }
}
