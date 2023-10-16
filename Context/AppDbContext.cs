using AlmoCar.Models;
using Microsoft.EntityFrameworkCore;

namespace AlmoCar.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){
    }

    public DbSet<Categoria> Categorias {get; set;}
    public DbSet<Item> Itens {get; set;}
    public DbSet<CarrinhoItem> CarrinhoItens{get;set;}
    }
}