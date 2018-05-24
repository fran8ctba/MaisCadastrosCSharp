using Models;
using System.Data.Entity;

namespace DataAPI.Context
{
    public partial class ApplicationDbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}