using DDP.CQRS.Domain;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace DDP.CQRS.DAL;

public class MyDbContext: DbContext
{

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }
    
    
    public DbSet<User> Users { get; set; }


}