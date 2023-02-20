using System.Configuration;
using DDP.CQRS.Commands;
using DDP.CQRS.DAL;
using DDP.CQRS.DAL.Repositories;
using DDP.CQRS.Domain;
using DDP.CQRS.Queries;
using Mediator;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddMediator(opt =>
{
    opt.ServiceLifetime = ServiceLifetime.Transient;
});
builder.Services.AddDbContext<MyDbContext>(
     options =>   options.UseInMemoryDatabase(databaseName: "UserDb")
    //options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection")
    );
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