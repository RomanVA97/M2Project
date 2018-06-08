using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace M2DAL.Migrations
{
    public partial class changemodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserPhone",
                table: "AspNetUsers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "UserPassword",
                table: "AspNetUsers",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "UserLogin",
                table: "AspNetUsers",
                newName: "Login");

            migrationBuilder.RenameColumn(
                name: "UserLastName",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "UserAge",
                table: "AspNetUsers",
                newName: "Age");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "AspNetUsers",
                newName: "UserPhone");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "AspNetUsers",
                newName: "UserPassword");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "AspNetUsers",
                newName: "UserLogin");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "UserLastName");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "AspNetUsers",
                newName: "UserAge");
        }
    }
}
