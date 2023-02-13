using DDP.Decorator.Repository;

var builder = WebApplication.CreateBuilder(args);

// Simple decorating of IAuthorRepository
// builder.Services.AddScoped<AuthorRepository>();
// builder.Services.AddScoped<IAuthorRepository>(provider => 
//     new CachedAuthorRepository(provider.GetRequiredService<AuthorRepository>()));

// Usage of Scrutor lib
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.Decorate<IAuthorRepository, CachedAuthorRepository>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/author/{id}", (IAuthorRepository authorRepository, string id) 
    => authorRepository.GetById(Guid.Parse(id)));

app.Run();