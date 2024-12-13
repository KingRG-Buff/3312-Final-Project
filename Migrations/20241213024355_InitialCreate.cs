using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3312_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CareerEvents",
                columns: table => new
                {
                    CareerEventID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventName = table.Column<string>(type: "TEXT", maxLength: 45, nullable: false),
                    EventDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventLocation = table.Column<string>(type: "TEXT", nullable: false),
                    EventDescription = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerEvents", x => x.CareerEventID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Major = table.Column<string>(type: "TEXT", nullable: false),
                    GradYear = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "StudentRegistrations",
                columns: table => new
                {
                    CareerEventID = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentID = table.Column<int>(type: "INTEGER", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentRegistrations", x => new { x.StudentID, x.CareerEventID });
                    table.ForeignKey(
                        name: "FK_StudentRegistrations_CareerEvents_CareerEventID",
                        column: x => x.CareerEventID,
                        principalTable: "CareerEvents",
                        principalColumn: "CareerEventID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentRegistrations_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentRegistrations_CareerEventID",
                table: "StudentRegistrations",
                column: "CareerEventID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentRegistrations");

            migrationBuilder.DropTable(
                name: "CareerEvents");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
