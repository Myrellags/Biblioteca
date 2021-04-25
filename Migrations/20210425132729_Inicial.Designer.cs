﻿// <auto-generated />
using System;
using Biblioteca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Biblioteca.Migrations
{
    [DbContext(typeof(MinhaBD))]
    [Migration("20210425132729_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Biblioteca.Autor", b =>
                {
                    b.Property<int>("AutorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LivroID")
                        .HasColumnType("int");

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoGeneroAutor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AutorID");

                    b.HasIndex("LivroID");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("Biblioteca.Categoria", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Biblioteca.Editora", b =>
                {
                    b.Property<int>("EditoraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EditoraID");

                    b.ToTable("Editoras");
                });

            modelBuilder.Entity("Biblioteca.Livro", b =>
                {
                    b.Property<int>("LivroID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEdicao")
                        .HasColumnType("datetime2");

                    b.Property<int>("EditoraID")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lingua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LivroID");

                    b.HasIndex("CategoriaID");

                    b.HasIndex("EditoraID");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("Biblioteca.Morada", b =>
                {
                    b.Property<int>("MoradaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conselho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EditoraID")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UtenteID")
                        .HasColumnType("int");

                    b.HasKey("MoradaID");

                    b.HasIndex("EditoraID");

                    b.HasIndex("UtenteID");

                    b.ToTable("Moradas");
                });

            modelBuilder.Entity("Biblioteca.Requisicao", b =>
                {
                    b.Property<int>("RequisicaoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("datetime2");

                    b.Property<int>("LivroID")
                        .HasColumnType("int");

                    b.Property<int>("UtenteID")
                        .HasColumnType("int");

                    b.HasKey("RequisicaoID");

                    b.HasIndex("LivroID");

                    b.HasIndex("UtenteID");

                    b.ToTable("Requisicoes");
                });

            modelBuilder.Entity("Biblioteca.Telefone", b =>
                {
                    b.Property<int>("TelefoneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EditoraID")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("UtenteID")
                        .HasColumnType("int");

                    b.HasKey("TelefoneID");

                    b.HasIndex("EditoraID");

                    b.HasIndex("UtenteID");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("Biblioteca.Utente", b =>
                {
                    b.Property<int>("UtenteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("LivrosDevolver")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtdEmprestimos")
                        .HasColumnType("int");

                    b.Property<DateTime>("UltimoEmprestimo")
                        .HasColumnType("datetime2");

                    b.HasKey("UtenteID");

                    b.ToTable("Utentes");
                });

            modelBuilder.Entity("Biblioteca.Autor", b =>
                {
                    b.HasOne("Biblioteca.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("Biblioteca.Livro", b =>
                {
                    b.HasOne("Biblioteca.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteca.Editora", "Editora")
                        .WithMany()
                        .HasForeignKey("EditoraID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Editora");
                });

            modelBuilder.Entity("Biblioteca.Morada", b =>
                {
                    b.HasOne("Biblioteca.Editora", "Editora")
                        .WithMany()
                        .HasForeignKey("EditoraID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteca.Utente", "Utente")
                        .WithMany()
                        .HasForeignKey("UtenteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Editora");

                    b.Navigation("Utente");
                });

            modelBuilder.Entity("Biblioteca.Requisicao", b =>
                {
                    b.HasOne("Biblioteca.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteca.Utente", "Utente")
                        .WithMany()
                        .HasForeignKey("UtenteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livro");

                    b.Navigation("Utente");
                });

            modelBuilder.Entity("Biblioteca.Telefone", b =>
                {
                    b.HasOne("Biblioteca.Editora", "Editora")
                        .WithMany()
                        .HasForeignKey("EditoraID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteca.Utente", "Utente")
                        .WithMany()
                        .HasForeignKey("UtenteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Editora");

                    b.Navigation("Utente");
                });
#pragma warning restore 612, 618
        }
    }
}