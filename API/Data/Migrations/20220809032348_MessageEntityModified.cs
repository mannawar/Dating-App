using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class MessageEntityModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_ReciepientId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ReciepientId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "ReciepientUsername",
                table: "Messages",
                newName: "RecipientUsername");

            migrationBuilder.AddColumn<int>(
                name: "RecipientId",
                table: "Messages",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_RecipientId",
                table: "Messages",
                column: "RecipientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_RecipientId",
                table: "Messages",
                column: "RecipientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_RecipientId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_RecipientId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "RecipientId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "RecipientUsername",
                table: "Messages",
                newName: "ReciepientUsername");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReciepientId",
                table: "Messages",
                column: "ReciepientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_ReciepientId",
                table: "Messages",
                column: "ReciepientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
