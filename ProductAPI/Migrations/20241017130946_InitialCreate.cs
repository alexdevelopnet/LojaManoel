using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dimensoes",
                columns: table => new
                {
                    DimensoesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    Largura = table.Column<int>(type: "int", nullable: false),
                    Comprimento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensoes", x => x.DimensoesId);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                });

            migrationBuilder.CreateTable(
                name: "CaixasDisponiveis",
                columns: table => new
                {
                    CaixaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DimensoesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaixasDisponiveis", x => x.CaixaId);
                    table.ForeignKey(
                        name: "FK_CaixasDisponiveis_Dimensoes_DimensoesId",
                        column: x => x.DimensoesId,
                        principalTable: "Dimensoes",
                        principalColumn: "DimensoesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    DimensoesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_Produtos_Dimensoes_DimensoesId",
                        column: x => x.DimensoesId,
                        principalTable: "Dimensoes",
                        principalColumn: "DimensoesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produtos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dimensoes",
                columns: new[] { "DimensoesId", "Altura", "Comprimento", "Largura" },
                values: new object[,]
                {
                    { 1, 30, 80, 40 },
                    { 2, 80, 40, 50 },
                    { 3, 50, 60, 80 }
                });

            migrationBuilder.InsertData(
                table: "CaixasDisponiveis",
                columns: new[] { "CaixaId", "DimensoesId" },
                values: new object[,]
                {
                    { "Caixa 1", 1 },
                    { "Caixa 2", 2 },
                    { "Caixa 3", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaixasDisponiveis_DimensoesId",
                table: "CaixasDisponiveis",
                column: "DimensoesId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_DimensoesId",
                table: "Produtos",
                column: "DimensoesId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PedidoId",
                table: "Produtos",
                column: "PedidoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaixasDisponiveis");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Dimensoes");

            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
