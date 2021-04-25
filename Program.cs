using Microsoft.EntityFrameworkCore;
using System;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class MinhaBD : DbContext 
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Morada> Moradas { get; set; }
        public DbSet<Requisicao> Requisicoes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Utente> Utentes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Conexao com uma Banco de Dados já criado
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BDBiblioteca;Trusted_Connection=True;");
            //Conexao criando o Banco de Dados
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDBiblioteca;Integrated Security=True;");
        }
    }
}
