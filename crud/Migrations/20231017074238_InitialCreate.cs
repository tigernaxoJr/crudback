using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace crud.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    gender = table.Column<int>(type: "integer", nullable: false),
                    idno = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "Name", "gender", "idno" },
                values: new object[,]
                {
                    { 1, "John Doe", 1, "1234567890" },
                    { 2, "Jane Doe", 0, "0987654321" },
                    { 3, "Alice Smith", 1, "1111111111" },
                    { 4, "Bob Johnson", 0, "2222222222" },
                    { 5, "Carol Brown", 1, "3333333333" },
                    { 6, "David Wilson", 0, "4444444444" },
                    { 7, "Eve Adams", 1, "5555555555" },
                    { 8, "Frank Miller", 0, "6666666666" },
                    { 9, "Grace Davis", 1, "7777777777" },
                    { 10, "Harry White", 0, "8888888888" },
                    { 11, "Isabel Thomas", 1, "9999999999" },
                    { 12, "Jack Lee", 0, "7777777000" },
                    { 13, "Karen Hall", 1, "5555555000" },
                    { 14, "Larry King", 0, "3333333000" },
                    { 15, "Megan Martin", 1, "1111111000" },
                    { 16, "Nora Clark", 0, "2222222000" },
                    { 17, "Oscar Young", 1, "4444444000" },
                    { 18, "Pamela White", 0, "6666666000" },
                    { 19, "Quincy Adams", 1, "8888888000" },
                    { 20, "Robert Davis", 0, "1234567000" },
                    { 21, "Sara Wilson", 1, "0987655000" },
                    { 22, "Tom Johnson", 0, "3333333000" },
                    { 23, "Ursula Smith", 1, "6666666000" },
                    { 24, "Victor Lee", 0, "1111111000" },
                    { 25, "Wendy Hall", 1, "5555555000" },
                    { 26, "Xander Martin", 0, "8888888000" },
                    { 27, "Yara Thomas", 1, "7777777000" },
                    { 28, "Zane King", 0, "2222222000" },
                    { 29, "Aaron Adams", 1, "4444444000" },
                    { 30, "Bella Martin", 0, "1234567000" },
                    { 31, "Chris White", 1, "0987655000" },
                    { 32, "Daisy Hall", 0, "5555555000" },
                    { 33, "Ethan King", 1, "6666666000" },
                    { 34, "Fiona Davis", 0, "2222222000" },
                    { 35, "George Wilson", 1, "1234567000" },
                    { 36, "Hannah Lee", 0, "7777777000" },
                    { 37, "Isaac Thomas", 1, "0987655000" },
                    { 38, "Julia Smith", 0, "4444444000" },
                    { 39, "Kai Adams", 1, "5555555000" },
                    { 40, "Lily King", 0, "6666666000" },
                    { 41, "Mike Davis", 1, "7777777000" },
                    { 42, "Nina Martin", 0, "2222222000" },
                    { 43, "Oliver Hall", 1, "1234567000" },
                    { 44, "Penny Lee", 0, "0987655000" },
                    { 45, "Quinn Thomas", 1, "4444444000" },
                    { 46, "Rachel Smith", 0, "5555555000" },
                    { 47, "Samuel Adams", 1, "1234567000" },
                    { 48, "Tina Davis", 0, "0987655000" },
                    { 49, "Ulysses Martin", 1, "6666666000" },
                    { 50, "Victoria Wilson", 0, "7777777000" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
