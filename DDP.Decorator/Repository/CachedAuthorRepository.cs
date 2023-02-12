using System.Collections.Concurrent;

namespace DDP.Decorator.Repository;

public class CachedAuthorRepository : IAuthorRepository
{
    private readonly IAuthorRepository _authorRepository;
    private static readonly ConcurrentDictionary<Guid, Author> _dict = new();

    public CachedAuthorRepository(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;

    }
    public Author GetById(Guid id)
    {
        return _dict.GetOrAdd(id, i => _authorRepository.GetById(i));
    }
}