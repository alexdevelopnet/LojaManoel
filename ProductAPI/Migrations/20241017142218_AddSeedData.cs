using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaixasDisponiveis_Dimensoes_DimensaoId",
                table: "CaixasDisponiveis");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Dimensoes_DimensaoId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CaixasDisponiveis",
                table: "CaixasDisponiveis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dimensoes",
                table: "Dimensoes");

            migrationBuilder.DeleteData(
                table: "Dimensoes",
                keyColumn: "DimensaoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dimensoes",
                keyColumn: "DimensaoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dimensoes",
                keyColumn: "DimensaoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dimensoes",
                keyColumn: "DimensaoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dimensoes",
                keyColumn: "DimensaoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dimensoes",
                keyColumn: "DimensaoId",
                keyValue: 6);

            migrationBuilder.RenameTable(
                name: "Dimensoes",
                newName: "Dimensao");

            migrationBuilder.AlterColumn<string>(
                name: "CaixaId",
                table: "CaixasDisponiveis",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "CaixaId",
                table: "CaixasDisponiveis",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CaixasDisponiveis",
                table: "CaixasDisponiveis",
                column: "CaixaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dimensoes",
                table: "Dimensoes",
                column: "DimensaoId");

            migrationBuilder.InsertData(
                table: "Dimensoes",
                columns: new[] { "DimensaoId", "Altura", "Comprimento", "Largura" },
                values: new object[,]
                {
                    { 1, 30f, 80f, 40f },
                    { 2, 80f, 40f, 50f },
                    { 3, 50f, 60f, 80f },
                    { 4, 40f, 25f, 10f },
                    { 5, 15f, 10f, 20f },
                    { 6, 25f, 20f, 15f }
                });

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
    }
}
