using DDP.Decorator.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<AuthorRepository>();
builder.Services.AddScoped<IAuthorRepository>(provider => 
    new CachedAuthorRepository(provider.GetRequiredService<AuthorRepository>()));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/author/{id}", (IAuthorRepository authorRepository, string id) 
    => authorRepository.GetById(Guid.Parse(id)));

app.Run();