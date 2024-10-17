using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaixasDisponiveis_Dimensao_DimensaoId",
                table: "CaixasDisponiveis");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Dimensao_DimensaoId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dimensao",
                table: "Dimensao");

            migrationBuilder.RenameTable(
                name: "Dimensao",
                newName: "Dimensoes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dimensoes",
                table: "Dimensoes",
                column: "DimensaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaixasDisponiveis_Dimensoes_DimensaoId",
                table: "CaixasDisponiveis",
                column: "DimensaoId",
                principalTable: "Dimensoes",
                principalColumn: "DimensaoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Dimensoes_DimensaoId",
                table: "Produtos",
                column: "DimensaoId",
                principalTable: "Dimensoes",
                principalColumn: "DimensaoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaixasDisponiveis_Dimensoes_DimensaoId",
                table: "CaixasDisponiveis");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Dimensoes_DimensaoId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dimensoes",
                table: "Dimensoes");

            migrationBuilder.RenameTable(
                name: "Dimensoes",
                newName: "Dimensao");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dimensao",
                table: "Dimensao",
                column: "DimensaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaixasDisponiveis_Dimensao_DimensaoId",
                table: "CaixasDisponiveis",
                column: "DimensaoId",
                principalTable: "Dimensao",
                principalColumn: "DimensaoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Dimensao_DimensaoId",
                table: "Produtos",
                column: "DimensaoId",
                principalTable: "Dimensao",
                principalColumn: "DimensaoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
