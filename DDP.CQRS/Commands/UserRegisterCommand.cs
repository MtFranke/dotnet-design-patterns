using DDP.CQRS.Domain;
using Mediator;

namespace DDP.CQRS.Commands;

public class UserRegisterCommand : ICommand
{
    public User User { get; set; }
}