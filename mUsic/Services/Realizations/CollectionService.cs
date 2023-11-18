using Microsoft.EntityFrameworkCore;
using mUsic.Database;
using mUsic.Services.Interfaces;
using mUsic.Services.Views;

namespace mUsic.Services.Realizations;

public class CollectionService : ICollectionService
{
    private MusicDbContext _dbContext;

    public CollectionService(MusicDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public List<SongView> GetSongByCollection(string collectionName)
    {
        var collection = _dbContext.Collections.Include(collection => collection.Songs)
            .FirstOrDefault(x => x.Name == collectionName);

        if (collection == null)
        {
            return new List<SongView>();
        }

        var songs = collection.Songs.Select(x => new SongView(x)).ToList();
        return songs;

    }
    
}