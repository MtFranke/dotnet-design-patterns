namespace DDP.Decorator.Repository;

public record Author(Guid Id);

public interface IAuthorRepository
{
    Author GetById(Guid id);
}

public class AuthorRepository: IAuthorRepository
{
    private IList<Author> _authors;
    public AuthorRepository()
    {
        _authors = new[] { new Author(Guid.NewGuid()) };
    }

    public Author GetById(Guid id)
    {
        return _authors.First(x=> x.Id == id);
    }
}