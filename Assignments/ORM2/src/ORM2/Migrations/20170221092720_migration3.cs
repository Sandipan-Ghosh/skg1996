using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ORM2.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductModels_UserModels_UserId",
                table: "ProductModels");

            migrationBuilder.DropTable(
                name: "UserModels");

            migrationBuilder.DropIndex(
                name: "IX_ProductModels_UserId",
                table: "ProductModels");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProductModels");

            migrationBuilder.CreateTable(
                name: "UpdateModels",
                columns: table => new
                {
                    UpdateId = table.Column<int>(maxLength: 5, nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    ProductModelsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateModels", x => x.UpdateId);
                    table.ForeignKey(
                        name: "FK_UpdateModels_ProductModels_ProductModelsId",
                        column: x => x.ProductModelsId,
                        principalTable: "ProductModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UpdateModels_ProductModelsId",
                table: "UpdateModels",
                column: "ProductModelsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UpdateModels");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ProductModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserModels",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: false),
                    date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModels", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductModels_UserId",
                table: "ProductModels",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductModels_UserModels_UserId",
                table: "ProductModels",
                column: "UserId",
                principalTable: "UserModels",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
