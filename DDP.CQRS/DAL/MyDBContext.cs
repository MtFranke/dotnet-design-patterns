using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DDP.CQRS.Domain;

namespace DDP.CQRS.DAL;

public class MyDBCOntext: DbContext
{
    public MyDBCOntext(): base("MyDBContext")
    {
    }
    
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
    
}