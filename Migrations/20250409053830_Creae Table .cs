using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseRepository.Migrations
{
    /// <inheritdoc />
    public partial class CreaeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MstRegistrations",
                columns: table => new
                {
                    RegistrationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(10)", nullable: true),
                    Address = table.Column<string>(type: "varchar(120)", nullable: true),
                    Message = table.Column<string>(type: "varchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MstRegistrations", x => x.RegistrationId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MstRegistrations");
        }
    }
}
