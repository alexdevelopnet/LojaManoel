using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Model.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
       public DbSet<Dimensao> Dimensoes { get; set; }

        public DbSet<CaixaDisponivel> CaixasDisponiveis { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CaixaDisponivel>()
         .HasNoKey();

            // Seed data for Pedidos
            modelBuilder.Entity<Pedido>()
                .HasData(
                    new Pedido { PedidoId = 1 },
                    new Pedido { PedidoId = 2 },
                    new Pedido { PedidoId = 3 },
                    new Pedido { PedidoId = 4 },
                    new Pedido { PedidoId = 5 },
                    new Pedido { PedidoId = 6 },
                    new Pedido { PedidoId = 7 },
                    new Pedido { PedidoId = 8 },
                    new Pedido { PedidoId = 9 },
                    new Pedido { PedidoId = 10 }
                );

            // Seed data for Produtos
            modelBuilder.Entity<Produto>()
                .HasData(
                    new Produto { ProdutoId = 1, ProdutoNome = "PS5", PedidoId = 1, DimensaoId = 1 },
                    new Produto { ProdutoId = 2, ProdutoNome = "Volante", PedidoId = 1, DimensaoId = 2 },
                    new Produto { ProdutoId = 3, ProdutoNome = "Joystick", PedidoId = 2, DimensaoId = 3 },
                    new Produto { ProdutoId = 4, ProdutoNome = "Fifa 24", PedidoId = 2, DimensaoId = 2 },
                    new Produto { ProdutoId = 5, ProdutoNome = "Call of Duty", PedidoId = 2, DimensaoId = 2 },
                    new Produto { ProdutoId = 6, ProdutoNome = "Headset", PedidoId = 3, DimensaoId = 1 },
                    new Produto { ProdutoId = 7, ProdutoNome = "Mouse Gamer", PedidoId = 4, DimensaoId = 1 },
                    new Produto { ProdutoId = 8, ProdutoNome = "Teclado Mecânico", PedidoId = 4, DimensaoId = 1 },
                    new Produto { ProdutoId = 9, ProdutoNome = "Cadeira Gamer", PedidoId = 5, DimensaoId = 3 },
                    new Produto { ProdutoId = 10, ProdutoNome = "Webcam", PedidoId = 6, DimensaoId = 1 },
                    new Produto { ProdutoId = 11, ProdutoNome = "Microfone", PedidoId = 6, DimensaoId = 1 },
                    new Produto { ProdutoId = 12, ProdutoNome = "Monitor", PedidoId = 6, DimensaoId = 3 },
                    new Produto { ProdutoId = 13, ProdutoNome = "Notebook", PedidoId = 6, DimensaoId = 1 },
                    new Produto { ProdutoId = 14, ProdutoNome = "Jogo de Cabos", PedidoId = 7, DimensaoId = 1 },
                    new Produto { ProdutoId = 15, ProdutoNome = "Controle Xbox", PedidoId = 8, DimensaoId = 1 },
                    new Produto { ProdutoId = 16, ProdutoNome = "Carregador", PedidoId = 8, DimensaoId = 1 },
                    new Produto { ProdutoId = 17, ProdutoNome = "Tablet", PedidoId = 9, DimensaoId = 1 },
                    new Produto { ProdutoId = 18, ProdutoNome = "HD Externo", PedidoId = 10, DimensaoId = 1 },
                    new Produto { ProdutoId = 19, ProdutoNome = "Pendrive", PedidoId = 10, DimensaoId = 1 }
                );
        }

    }

}
