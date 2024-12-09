﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRolev4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserMaster_RoleId",
                table: "UserMaster");

            migrationBuilder.CreateIndex(
                name: "IX_UserMaster_RoleId",
                table: "UserMaster",
                column: "RoleId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserMaster_RoleId",
                table: "UserMaster");

            migrationBuilder.CreateIndex(
                name: "IX_UserMaster_RoleId",
                table: "UserMaster",
                column: "RoleId");
        }
    }
}
