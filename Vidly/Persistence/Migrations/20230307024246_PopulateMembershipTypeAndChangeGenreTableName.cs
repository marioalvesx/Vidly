using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PopulateMembershipTypeAndChangeGenreTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 'Pay As You Go', 0, 0, 0)");
            migrationBuilder.Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 'Pay As You Go', 30, 1, 10)");
            migrationBuilder.Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 'Monthly', 90, 3, 15)");
            migrationBuilder.Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 'Annual', 300, 12, 20)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
