using DDP.CQRS.Domain;

namespace DDP.CQRS.DAL.Repositories;

public class UserRepository : IUserRepository
{
    private readonly MyDBCOntext _context;

    public UserRepository(MyDBCOntext context)
    {
        _context = context;
    }

    public async Task<IList<User>> Get()
    {
        var students = _context.Users.ToList();
        return students;
    }
}