using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecondRoundProject.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "BeneficiaryName",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "SWIFTCode",
                table: "Units");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Units",
                newName: "ZipCode");

            migrationBuilder.AddColumn<string>(
                name: "ID",
                table: "Units",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Account",
                table: "Units",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Units",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Units",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Units",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "Units",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Units",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "Units",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Units",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Units",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Units",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Units",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Units",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Units",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Account",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "FName",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Units");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Units",
                newName: "Amount");

            migrationBuilder.AddColumn<int>(
                name: "TransactionId",
                table: "Units",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "Units",
                type: "nvarchar(12)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "Units",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryName",
                table: "Units",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Units",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SWIFTCode",
                table: "Units",
                type: "nvarchar(11)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "TransactionId");
        }
    }
}
