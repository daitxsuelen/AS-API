using Microsoft.EntityFrameworkCore;


public class AppDbContext : DbContext
{
    public DbSet<Fornecedor> Fornecedores {get; set; }
    public DbSet<Pedido> Pedidos {get; set; }
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = banco.db");
    }
}