using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class MessageEntityModifiedRecipient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReciepientDeleted",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "ReciepientId",
                table: "Messages",
                newName: "RecipientDeleted");

            migrationBuilder.AlterColumn<int>(
                name: "RecipientId",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecipientDeleted",
                table: "Messages",
                newName: "ReciepientId");

            migrationBuilder.AlterColumn<int>(
                name: "RecipientId",
                table: "Messages",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<bool>(
                name: "ReciepientDeleted",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
