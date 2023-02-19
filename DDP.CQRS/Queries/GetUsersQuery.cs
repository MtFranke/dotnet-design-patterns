using DDP.CQRS.Domain;
using Mediator;

namespace DDP.CQRS.Queries;

public class GetUsersQuery : IQuery<IList<User>>
{
    public GetUsersQuery()
    {
        
    }
}