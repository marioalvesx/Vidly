using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMembershipTypeValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE MembershipType SET name = 'Pay As You Go' WHERE Id = 2");
            migrationBuilder.Sql("UPDATE MembershipType SET name = 'Monthly' WHERE Id = 3");
            migrationBuilder.Sql("UPDATE MembershipType SET name = 'Annual' WHERE Id = 4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
