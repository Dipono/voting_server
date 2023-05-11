using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Android.Voting.Data.Migrations
{
    /// <inheritdoc />
    public partial class added_list : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disagreed",
                table: "Votes");

            migrationBuilder.RenameColumn(
                name: "SatrtDate",
                table: "Issues",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Issues",
                newName: "EndTime");

            migrationBuilder.AlterColumn<bool>(
                name: "Agreed",
                table: "Votes",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Issues",
                newName: "SatrtDate");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "Issues",
                newName: "EndDate");

            migrationBuilder.AlterColumn<string>(
                name: "Agreed",
                table: "Votes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "Disagreed",
                table: "Votes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
