using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApiGateway.Persistance.Migrations
{
    public partial class RemoveCustomerIdcolumnfromConfigurationAgent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                schema: "Configuration",
                table: "Agents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                schema: "Configuration",
                table: "Agents",
                nullable: false,
                defaultValue: 0);
        }
    }
}
