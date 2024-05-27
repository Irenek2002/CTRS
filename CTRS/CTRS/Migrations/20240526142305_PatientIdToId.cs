using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTRS.Migrations
{
    /// <inheritdoc />
    public partial class PatientIdToId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthEdus",
                table: "HealthEdus");

            migrationBuilder.RenameTable(
                name: "HealthEdus",
                newName: "HealthEdu");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Patients",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthEdu",
                table: "HealthEdu",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthEdu",
                table: "HealthEdu");

            migrationBuilder.RenameTable(
                name: "HealthEdu",
                newName: "HealthEdus");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Patients",
                newName: "PatientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthEdus",
                table: "HealthEdus",
                column: "Id");
        }
    }
}
