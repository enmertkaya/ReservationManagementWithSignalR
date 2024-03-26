using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalRQRReservation.DataAccessLayer.Migrations
{
    public partial class delete_about_socialmedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocialMedia",
                table: "Abouts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SocialMedia",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
