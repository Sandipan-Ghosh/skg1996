using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ORM2.Migrations
{
    public partial class MIGRATIONS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UpdateModels_ProductModels_ProductModelsId",
                table: "UpdateModels");

            migrationBuilder.DropIndex(
                name: "IX_UpdateModels_ProductModelsId",
                table: "UpdateModels");

            migrationBuilder.DropColumn(
                name: "ProductModelsId",
                table: "UpdateModels");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UpdateModels",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "UpdateModels",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UpdateModels_Id",
                table: "UpdateModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UpdateModels_ProductModels_Id",
                table: "UpdateModels",
                column: "Id",
                principalTable: "ProductModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UpdateModels_ProductModels_Id",
                table: "UpdateModels");

            migrationBuilder.DropIndex(
                name: "IX_UpdateModels_Id",
                table: "UpdateModels");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UpdateModels",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "UpdateModels",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "ProductModelsId",
                table: "UpdateModels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UpdateModels_ProductModelsId",
                table: "UpdateModels",
                column: "ProductModelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_UpdateModels_ProductModels_ProductModelsId",
                table: "UpdateModels",
                column: "ProductModelsId",
                principalTable: "ProductModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
