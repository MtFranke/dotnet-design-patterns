using DDP.CQRS.Model;
using Mediator;

namespace DDP.CQRS.Commands;

public class UserRegisterCommand : ICommand
{
    public User User { get; set; }
}