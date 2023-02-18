using DDP.CQRS.Commands;
using DDP.CQRS.Queries;
using Mediator;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMediator();
var app = builder.Build();

app.MapPost("/user",  async (UserRegisterCommand command, IMediator mediator) =>
{
    await mediator.Send(command);
    return Results.Ok();
});

app.MapGet("/user",  async (IMediator mediator) =>
{
    var response = await mediator.Send(new GetUsersQuery());
    return Results.Ok(response);
});

app.Run();