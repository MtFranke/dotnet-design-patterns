namespace DDP.CQRS.Domain;

public interface IUserRepository
{
    Task<IList<User>> Get();
}