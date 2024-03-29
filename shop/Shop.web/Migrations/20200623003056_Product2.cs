﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.web.Migrations
{
    public partial class Product2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    LastPurchase = table.Column<DateTime>(nullable: false),
                    LastSale = table.Column<DateTime>(nullable: false),
                    IsAvailabe = table.Column<bool>(nullable: false),
                    Stock = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products2", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products2");
        }
    }
}
