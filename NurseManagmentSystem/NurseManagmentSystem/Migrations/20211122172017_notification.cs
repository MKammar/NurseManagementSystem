using Microsoft.EntityFrameworkCore.Migrations;

namespace NurseManagmentSystem.Migrations
{
    public partial class notification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "notifications",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notifications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "notificationsApplicationUsers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    notificationId = table.Column<int>(nullable: false),
                    userId = table.Column<string>(nullable: true),
                    isRead = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notificationsApplicationUsers", x => x.id);
                    table.ForeignKey(
                        name: "FK_notificationsApplicationUsers_notifications_notificationId",
                        column: x => x.notificationId,
                        principalTable: "notifications",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_notificationsApplicationUsers_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_notificationsApplicationUsers_notificationId",
                table: "notificationsApplicationUsers",
                column: "notificationId");

            migrationBuilder.CreateIndex(
                name: "IX_notificationsApplicationUsers_userId",
                table: "notificationsApplicationUsers",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "notificationsApplicationUsers");

            migrationBuilder.DropTable(
                name: "notifications");
        }
    }
}
