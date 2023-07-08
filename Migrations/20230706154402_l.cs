using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentDetails.Migrations
{
    /// <inheritdoc />
    public partial class l : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "School_Name",
                table: "Stud_detail");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_detail_School_Code",
                table: "Stud_detail",
                column: "School_Code",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_detail_M_School_School_Code",
                table: "Stud_detail",
                column: "School_Code",
                principalTable: "M_School",
                principalColumn: "School_Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_detail_Stud_detail_School_Code",
                table: "Stud_detail",
                column: "School_Code",
                principalTable: "Stud_detail",
                principalColumn: "Stud_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_detail_M_School_School_Code",
                table: "Stud_detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_detail_Stud_detail_School_Code",
                table: "Stud_detail");

            migrationBuilder.DropIndex(
                name: "IX_Stud_detail_School_Code",
                table: "Stud_detail");

            migrationBuilder.AddColumn<string>(
                name: "School_Name",
                table: "Stud_detail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
