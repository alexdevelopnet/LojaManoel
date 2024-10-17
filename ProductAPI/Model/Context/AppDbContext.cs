using Microsoft.EntityFrameworkCore;

namespace ProductAPI.Model.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Dimensoes> Dimensoes { get; set; }
        public DbSet<CaixaDisponivel> CaixasDisponiveis { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Definindo as chaves primárias
            modelBuilder.Entity<CaixaDisponivel>().HasKey(c => c.CaixaId);
            modelBuilder.Entity<Dimensoes>().HasKey(d => d.DimensoesId);

            // Configurando o relacionamento entre CaixaDisponivel e Dimensoes
            modelBuilder.Entity<CaixaDisponivel>()
                .HasOne(c => c.Dimensoes)
                .WithMany()
                .HasForeignKey(c => c.DimensoesId);

            // Seed Data: Dimensoes
            modelBuilder.Entity<Dimensoes>().HasData(
                new Dimensoes { DimensoesId = 1, Altura = 30, Largura = 40, Comprimento = 80 },
                new Dimensoes { DimensoesId = 2, Altura = 80, Largura = 50, Comprimento = 40 },
                new Dimensoes { DimensoesId = 3, Altura = 50, Largura = 80, Comprimento = 60 }
            );

            // Seed Data: CaixaDisponivel com referência correta a DimensoesId
            modelBuilder.Entity<CaixaDisponivel>().HasData(
                new CaixaDisponivel { CaixaId = "Caixa 1", DimensoesId = 1 },
                new CaixaDisponivel { CaixaId = "Caixa 2", DimensoesId = 2 },
                new CaixaDisponivel { CaixaId = "Caixa 3", DimensoesId = 3 }
            );
        }

    }

}
