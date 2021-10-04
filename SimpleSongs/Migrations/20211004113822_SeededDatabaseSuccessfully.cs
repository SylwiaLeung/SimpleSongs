using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleSongs.Migrations
{
    public partial class SeededDatabaseSuccessfully : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 1, "In Dreams", "Roy Orbison", 2.1499999999999999, "House Without Windows" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 2, "In Dreams", "Roy Orbison", 2.5099999999999998, "In Dreams" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 3, "In Dreams", "Roy Orbison", 2.5699999999999998, "Lonely Wine" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 4, "S&M", "Metallica", 4.3600000000000003, "Fuel" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 5, "S&M", "Metallica", 9.3399999999999999, "Master of Puppets" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "AlbumName", "Author", "Length", "Title" },
                values: new object[] { 6, "Load", "Metallica", 5.2000000000000002, "Mama Said" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
