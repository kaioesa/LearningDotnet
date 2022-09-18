using Microsoft.EntityFrameworkCore;

namespace CRUD_asp_mvc.Models;

public class DbConfig : DbContext
{
    public DbSet<Client> Clients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=.; Database=sqlserver-crud; Integrated Security=True");
    }
}