using Mediator;

namespace DDP.CQRS.Commands;

public class UserRegisterCommandHandler : ICommandHandler<UserRegisterCommand>
{
    public ValueTask<Unit> Handle(UserRegisterCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}