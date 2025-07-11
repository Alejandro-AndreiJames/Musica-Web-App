﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musica_Web_App.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTrackingToSongs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Song",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Song",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Song",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Song",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Song");
        }
    }
}
