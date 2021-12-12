using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Worktastic.Data.Migrations
{
    public partial class RenameToCompanyImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactImage",
                table: "JobPostings");

            migrationBuilder.AddColumn<byte[]>(
                name: "CompanyImage",
                table: "JobPostings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyImage",
                table: "JobPostings");

            migrationBuilder.AddColumn<byte[]>(
                name: "ContactImage",
                table: "JobPostings",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
