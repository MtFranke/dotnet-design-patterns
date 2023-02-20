using DDP.CQRS.Domain;

namespace DDP.CQRS.DAL.Repositories;

public class UserRepository : IUserRepository
{
    private readonly MyDbContext _context;

    public UserRepository(MyDbContext context)
    {
        _context = context;
        _context.Users.Add(new User("John", "Doe"));
        _context.SaveChanges();
    }

    public async Task<IList<User>> Get()
    {
        var students = _context.Users.ToList();
        return students;
    }
}