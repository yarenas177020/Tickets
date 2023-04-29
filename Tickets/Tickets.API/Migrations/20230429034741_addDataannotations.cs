using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.API.Migrations
{
    /// <inheritdoc />
    public partial class addDataannotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tickets_TicketID",
                table: "Tickets");

            migrationBuilder.AlterColumn<string>(
                name: "TicketID",
                table: "Tickets",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TicketID",
                table: "Tickets",
                column: "TicketID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tickets_TicketID",
                table: "Tickets");

            migrationBuilder.AlterColumn<string>(
                name: "TicketID",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TicketID",
                table: "Tickets",
                column: "TicketID",
                unique: true,
                filter: "[TicketID] IS NOT NULL");
        }
    }
}
