using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PescaAPI.Migrations
{
    /// <inheritdoc />
    public partial class novo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Venda_VendaId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_VendaId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "Produto");

            migrationBuilder.AddColumn<Guid>(
                name: "ProdutoId",
                table: "Venda",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ProdutoId",
                table: "Venda",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Produto_ProdutoId",
                table: "Venda",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Produto_ProdutoId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_ProdutoId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Venda");

            migrationBuilder.AddColumn<Guid>(
                name: "VendaId",
                table: "Produto",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_VendaId",
                table: "Produto",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Venda_VendaId",
                table: "Produto",
                column: "VendaId",
                principalTable: "Venda",
                principalColumn: "VendaId");
        }
    }
}
