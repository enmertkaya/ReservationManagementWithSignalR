using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalRQRReservation.DataAccessLayer.Migrations
{
    public partial class change_forapi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ChangeStatus",
                table: "Changes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChangeStatus",
                table: "Changes");
        }
    }
}
