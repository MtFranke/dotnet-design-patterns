using DDP.CQRS.Model;
using Mediator;

namespace DDP.CQRS.Queries;

public class GetUsersQuery : IQuery<IList<User>>
{
    public GetUsersQuery()
    {
        
    }
}