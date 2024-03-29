﻿// <auto-generated />
using System;
using Desenvolvimento.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Desenvolvimento.Data.Migrations
{
    [DbContext(typeof(DesenvolverAPIContexto))]
    partial class DesenvolverAPIContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Desenvolvimento.Entidade.Entidade.Administrador", b =>
                {
                    b.Property<int>("IdAdm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAdm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Login")
                        .HasColumnType("int");

                    b.Property<string>("NomeAdm")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAdm");

                    b.HasIndex("Id_Login");

                    b.ToTable("tb_Administrador");
                });

            modelBuilder.Entity("Desenvolvimento.Entidade.Entidade.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id_Cliente")
                        .HasColumnType("int");

                    b.Property<int>("Id_Login")
                        .HasColumnType("int");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SexoCliente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.HasIndex("Id_Cliente");

                    b.ToTable("tb_Cliente");
                });

            modelBuilder.Entity("Desenvolvimento.Entidade.Entidade.Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemnto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Cliente")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEndereco");

                    b.HasIndex("Id_Cliente");

                    b.ToTable("tb_Endereco");
                });

            modelBuilder.Entity("Desenvolvimento.Entidade.Entidade.Login", b =>
                {
                    b.Property<int>("IdLogin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Perfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLogin");

                    b.ToTable("tb_Login");
                });

            modelBuilder.Entity("Desenvolvimento.Entidade.Entidade.Loja", b =>
                {
                    b.Property<int>("IdLoja")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Cliente")
                        .HasColumnType("int");

                    b.Property<string>("NomeLoja")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLoja");

                    b.HasIndex("Id_Cliente");

                    b.ToTable("tb_Loja");
                });

            modelBuilder.Entity("Desenvolvimento.Entidade.Entidade.Pagamento", b =>
                {
                    b.Property<int>("IdPagamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Produto")
                        .HasColumnType("int");

                    b.Property<float>("PrecoPagamento")
                        .HasColumnType("real");

                    b.Property<int>("QtdePagamento")
                        .HasColumnType("int");

                    b.HasKey("IdPagamento");

                    b.HasIndex("Id_Produto");

                    b.ToTable("tb_Pagamento");
                });

            modelBuilder.Entity("Desenvolvimento.Entidade.Entidade.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaqoProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Loja")
                        .HasColumnType("int");

                    b.Property<string>("NomeProd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProduto");

                    b.HasIndex("Id_Loja");

                    b.ToTable("tb_Produto");
                });

            modelBuilder.Entity("Desenvolvimento.Entidade.Entidade.Administrador", b =>
                {
                    b.HasOne("Desenvolvimento.Entidade.Entidade.Login", "Login")
                        .WithMany()
                        .HasForeignKey("Id_Login")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Login");
                });

            modelBuilder.Entity("Desenvolvimento.Entidade.Entidade.Cliente", b =>
                {
                    b.HasOne("Desenvolvimento.Entidade.Entidade.Login", "Login")
                        .WithMany()
                        .HasForeignKey("Id_Cliente");

                    b.Navigation("Login");
                });

            modelBuilder.Entity("Desenvolvimento.Entidade.Entidade.Endereco", b =>
                {
                    b.HasOne("Desenvolvimento.Entidade.Entidade.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("Id_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Desenvolvimento.Entidade.Entidade.Loja", b =>
                {
                    b.HasOne("Desenvolvimento.Entidade.Entidade.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("Id_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Desenvolvimento.Entidade.Entidade.Pagamento", b =>
                {
                    b.HasOne("Desenvolvimento.Entidade.Entidade.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("Id_Produto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Desenvolvimento.Entidade.Entidade.Produto", b =>
                {
                    b.HasOne("Desenvolvimento.Entidade.Entidade.Loja", "Loja")
                        .WithMany()
                        .HasForeignKey("Id_Loja")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loja");
                });
#pragma warning restore 612, 618
        }
    }
}
