using DDP.CQRS.Domain;
using Mediator;

namespace DDP.CQRS.Queries;

public class GetUserQueryHandlers : IQueryHandler<GetUsersQuery, IList<User>>
{
    private readonly IUserRepository _userRepository;

    public GetUserQueryHandlers(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async ValueTask<IList<User>> Handle(GetUsersQuery query, CancellationToken cancellationToken)
    {
        var response = await _userRepository.Get();
        return response;
    }
}