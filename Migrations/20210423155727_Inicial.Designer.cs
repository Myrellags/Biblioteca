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
    [Migration("20210423155727_Inicial")]
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

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Saidas")
                        .HasColumnType("int");

                    b.Property<string>("TipoGeneroAutor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AutorID");

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

            modelBuilder.Entity("Biblioteca.Controle", b =>
                {
                    b.Property<int>("ControleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AutorID")
                        .HasColumnType("int");

                    b.Property<int?>("CategoriaID1")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EditoraID1")
                        .HasColumnType("int");

                    b.Property<int?>("LivroID1")
                        .HasColumnType("int");

                    b.Property<int?>("UtenteID1")
                        .HasColumnType("int");

                    b.HasKey("ControleID");

                    b.HasIndex("AutorID");

                    b.HasIndex("CategoriaID1");

                    b.HasIndex("EditoraID1");

                    b.HasIndex("LivroID1");

                    b.HasIndex("UtenteID1");

                    b.ToTable("Controles");
                });

            modelBuilder.Entity("Biblioteca.Editora", b =>
                {
                    b.Property<int>("EditoraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Morada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
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

                    b.Property<int?>("AutorID1")
                        .HasColumnType("int");

                    b.Property<int?>("CategoriaID1")
                        .HasColumnType("int");

                    b.Property<string>("DataEdicao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EditoraID1")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LivroID");

                    b.HasIndex("AutorID1");

                    b.HasIndex("CategoriaID1");

                    b.HasIndex("EditoraID1");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("Biblioteca.Utente", b =>
                {
                    b.Property<int>("UtenteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("LivrosDevolver")
                        .HasColumnType("bit");

                    b.Property<string>("Morada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtdEmprestimos")
                        .HasColumnType("int");

                    b.Property<string>("Telemovel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UltimoEmprestimo")
                        .HasColumnType("datetime2");

                    b.HasKey("UtenteID");

                    b.ToTable("Utentes");
                });

            modelBuilder.Entity("Biblioteca.Controle", b =>
                {
                    b.HasOne("Biblioteca.Autor", "AutorId")
                        .WithMany()
                        .HasForeignKey("AutorID");

                    b.HasOne("Biblioteca.Categoria", "CategoriaID")
                        .WithMany()
                        .HasForeignKey("CategoriaID1");

                    b.HasOne("Biblioteca.Editora", "EditoraID")
                        .WithMany()
                        .HasForeignKey("EditoraID1");

                    b.HasOne("Biblioteca.Livro", "LivroID")
                        .WithMany()
                        .HasForeignKey("LivroID1");

                    b.HasOne("Biblioteca.Utente", "UtenteID")
                        .WithMany()
                        .HasForeignKey("UtenteID1");

                    b.Navigation("AutorId");

                    b.Navigation("CategoriaID");

                    b.Navigation("EditoraID");

                    b.Navigation("LivroID");

                    b.Navigation("UtenteID");
                });

            modelBuilder.Entity("Biblioteca.Livro", b =>
                {
                    b.HasOne("Biblioteca.Autor", "AutorID")
                        .WithMany()
                        .HasForeignKey("AutorID1");

                    b.HasOne("Biblioteca.Categoria", "CategoriaID")
                        .WithMany()
                        .HasForeignKey("CategoriaID1");

                    b.HasOne("Biblioteca.Editora", "EditoraID")
                        .WithMany()
                        .HasForeignKey("EditoraID1");

                    b.Navigation("AutorID");

                    b.Navigation("CategoriaID");

                    b.Navigation("EditoraID");
                });
#pragma warning restore 612, 618
        }
    }
}
