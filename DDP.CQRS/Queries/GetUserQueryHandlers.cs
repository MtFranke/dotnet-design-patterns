using DDP.CQRS.Domain;
using Mediator;

namespace DDP.CQRS.Queries;

public class GetUserQueryHandlers : IQueryHandler<GetUsersQuery, IList<User>>
{
    public ValueTask<IList<User>> Handle(GetUsersQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}