using System.Collections.Concurrent;

namespace DDP.Decorator.Repository;

public class CachedAuthorRepository : IAuthorRepository
{
    private readonly IAuthorRepository _authorRepository;
    private readonly ConcurrentDictionary<Guid, Author> _dict;

    public CachedAuthorRepository(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
        _dict = new ConcurrentDictionary<Guid, Author>();

    }
    public Author GetById(Guid id)
    {
        return _dict.GetOrAdd(id, i => _authorRepository.GetById(i));
    }
}