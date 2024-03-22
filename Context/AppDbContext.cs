using apifunc.Models;
using Microsoft.EntityFrameworkCore;

namespace apifunc.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}
    public DbSet<Funcionario> Funcionarios{get; set;}
    public DbSet<Setor> Setores{get; set;}
    
}

