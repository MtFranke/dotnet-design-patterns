using DDP.CQRS.Queries;
using Mediator;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMediator();
var app = builder.Build();

app.MapGet("/example",  async (IMediator mediator) =>
{
    var ping = new Ping(Guid.NewGuid());
    await mediator.Send(ping);
});

app.Run();