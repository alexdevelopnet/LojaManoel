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
                    DimensaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Altura = table.Column<float>(type: "real", nullable: false),
                    Largura = table.Column<float>(type: "real", nullable: false),
                    Comprimento = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensoes", x => x.DimensaoId);
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
                    DimensaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaixasDisponiveis", x => x.CaixaId);
                    table.ForeignKey(
                        name: "FK_CaixasDisponiveis_Dimensoes_DimensaoId",
                        column: x => x.DimensaoId,
                        principalTable: "Dimensoes",
                        principalColumn: "DimensaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    DimensaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_Produtos_Dimensoes_DimensaoId",
                        column: x => x.DimensaoId,
                        principalTable: "Dimensoes",
                        principalColumn: "DimensaoId",
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

            migrationBuilder.InsertData(
                table: "Pedidos",
                column: "PedidoId",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "DimensaoId", "PedidoId", "ProdutoNome" },
                values: new object[,]
                {
                    { 1, 1, 1, "PS5" },
                    { 2, 2, 1, "Volante" },
                    { 3, 3, 2, "Joystick" },
                    { 4, 2, 2, "Fifa 24" },
                    { 5, 2, 2, "Call of Duty" },
                    { 6, 1, 3, "Headset" },
                    { 7, 1, 4, "Mouse Gamer" },
                    { 8, 1, 4, "Teclado Mecânico" },
                    { 9, 3, 5, "Cadeira Gamer" },
                    { 10, 1, 6, "Webcam" },
                    { 11, 1, 6, "Microfone" },
                    { 12, 3, 6, "Monitor" },
                    { 13, 1, 6, "Notebook" },
                    { 14, 1, 7, "Jogo de Cabos" },
                    { 15, 1, 8, "Controle Xbox" },
                    { 16, 1, 8, "Carregador" },
                    { 17, 1, 9, "Tablet" },
                    { 18, 1, 10, "HD Externo" },
                    { 19, 1, 10, "Pendrive" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaixasDisponiveis_DimensaoId",
                table: "CaixasDisponiveis",
                column: "DimensaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_DimensaoId",
                table: "Produtos",
                column: "DimensaoId");

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
