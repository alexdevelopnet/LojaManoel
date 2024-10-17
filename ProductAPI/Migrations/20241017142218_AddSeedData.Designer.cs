﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductAPI.Model.Context;

#nullable disable

namespace ProductAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241017142218_AddSeedData")]
    partial class AddSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductAPI.Model.CaixaDisponivel", b =>
                {
                    b.Property<string>("CaixaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DimensaoId")
                        .HasColumnType("int");

                    b.HasIndex("DimensaoId");

                    b.ToTable("CaixasDisponiveis");
                });

            modelBuilder.Entity("ProductAPI.Model.Dimensao", b =>
                {
                    b.Property<int>("DimensaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DimensaoId"));

                    b.Property<float>("Altura")
                        .HasColumnType("real");

                    b.Property<float>("Comprimento")
                        .HasColumnType("real");

                    b.Property<float>("Largura")
                        .HasColumnType("real");

                    b.HasKey("DimensaoId");

                    b.ToTable("Dimensao");
                });

            modelBuilder.Entity("ProductAPI.Model.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PedidoId"));

                    b.HasKey("PedidoId");

                    b.ToTable("Pedidos");

                    b.HasData(
                        new
                        {
                            PedidoId = 1
                        },
                        new
                        {
                            PedidoId = 2
                        },
                        new
                        {
                            PedidoId = 3
                        },
                        new
                        {
                            PedidoId = 4
                        },
                        new
                        {
                            PedidoId = 5
                        },
                        new
                        {
                            PedidoId = 6
                        },
                        new
                        {
                            PedidoId = 7
                        },
                        new
                        {
                            PedidoId = 8
                        },
                        new
                        {
                            PedidoId = 9
                        },
                        new
                        {
                            PedidoId = 10
                        });
                });

            modelBuilder.Entity("ProductAPI.Model.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutoId"));

                    b.Property<int>("DimensaoId")
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<string>("ProdutoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProdutoId");

                    b.HasIndex("DimensaoId");

                    b.HasIndex("PedidoId");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            ProdutoId = 1,
                            DimensaoId = 1,
                            PedidoId = 1,
                            ProdutoNome = "PS5"
                        },
                        new
                        {
                            ProdutoId = 2,
                            DimensaoId = 2,
                            PedidoId = 1,
                            ProdutoNome = "Volante"
                        },
                        new
                        {
                            ProdutoId = 3,
                            DimensaoId = 3,
                            PedidoId = 2,
                            ProdutoNome = "Joystick"
                        },
                        new
                        {
                            ProdutoId = 4,
                            DimensaoId = 2,
                            PedidoId = 2,
                            ProdutoNome = "Fifa 24"
                        },
                        new
                        {
                            ProdutoId = 5,
                            DimensaoId = 2,
                            PedidoId = 2,
                            ProdutoNome = "Call of Duty"
                        },
                        new
                        {
                            ProdutoId = 6,
                            DimensaoId = 1,
                            PedidoId = 3,
                            ProdutoNome = "Headset"
                        },
                        new
                        {
                            ProdutoId = 7,
                            DimensaoId = 1,
                            PedidoId = 4,
                            ProdutoNome = "Mouse Gamer"
                        },
                        new
                        {
                            ProdutoId = 8,
                            DimensaoId = 1,
                            PedidoId = 4,
                            ProdutoNome = "Teclado Mecânico"
                        },
                        new
                        {
                            ProdutoId = 9,
                            DimensaoId = 3,
                            PedidoId = 5,
                            ProdutoNome = "Cadeira Gamer"
                        },
                        new
                        {
                            ProdutoId = 10,
                            DimensaoId = 1,
                            PedidoId = 6,
                            ProdutoNome = "Webcam"
                        },
                        new
                        {
                            ProdutoId = 11,
                            DimensaoId = 1,
                            PedidoId = 6,
                            ProdutoNome = "Microfone"
                        },
                        new
                        {
                            ProdutoId = 12,
                            DimensaoId = 3,
                            PedidoId = 6,
                            ProdutoNome = "Monitor"
                        },
                        new
                        {
                            ProdutoId = 13,
                            DimensaoId = 1,
                            PedidoId = 6,
                            ProdutoNome = "Notebook"
                        },
                        new
                        {
                            ProdutoId = 14,
                            DimensaoId = 1,
                            PedidoId = 7,
                            ProdutoNome = "Jogo de Cabos"
                        },
                        new
                        {
                            ProdutoId = 15,
                            DimensaoId = 1,
                            PedidoId = 8,
                            ProdutoNome = "Controle Xbox"
                        },
                        new
                        {
                            ProdutoId = 16,
                            DimensaoId = 1,
                            PedidoId = 8,
                            ProdutoNome = "Carregador"
                        },
                        new
                        {
                            ProdutoId = 17,
                            DimensaoId = 1,
                            PedidoId = 9,
                            ProdutoNome = "Tablet"
                        },
                        new
                        {
                            ProdutoId = 18,
                            DimensaoId = 1,
                            PedidoId = 10,
                            ProdutoNome = "HD Externo"
                        },
                        new
                        {
                            ProdutoId = 19,
                            DimensaoId = 1,
                            PedidoId = 10,
                            ProdutoNome = "Pendrive"
                        });
                });

            modelBuilder.Entity("ProductAPI.Model.CaixaDisponivel", b =>
                {
                    b.HasOne("ProductAPI.Model.Dimensao", "Dimensao")
                        .WithMany()
                        .HasForeignKey("DimensaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dimensao");
                });

            modelBuilder.Entity("ProductAPI.Model.Produto", b =>
                {
                    b.HasOne("ProductAPI.Model.Dimensao", "Dimensao")
                        .WithMany()
                        .HasForeignKey("DimensaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductAPI.Model.Pedido", "Pedido")
                        .WithMany("Produtos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dimensao");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("ProductAPI.Model.Pedido", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
