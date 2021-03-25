using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeesLeaveManagementSystem.Migrations
{
    public partial class AddCommentsandCancelledFlag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Cancelled",
                table: "LeaveRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cancelled",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "RequestComments",
                table: "LeaveRequests");
        }
    }
}
