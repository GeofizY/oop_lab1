using Microsoft.EntityFrameworkCore;
using Models;
using mUsic.Database;
using mUsic.Services.Interfaces;
using mUsic.Services.Views;

namespace mUsic.Services.Realizations;

public class SongService : ISongService
{
    private MusicDbContext _dbContext;

    public SongService(MusicDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public List<SongView> GetSongs()
    {
         return _dbContext.Songs.Select(s => new SongView(s)).ToList<SongView>();
    }
    
    public List<SongView> GetSongs(string songName)
    {
        return _dbContext.Songs
            .Where(x => x.Name.ToLower() == songName.ToLower())
            .Select(x => new SongView(x))
            .ToList<SongView>();
    }
    
    public List<SongView> GetSongsByAuthor(string authorName)
    {
        var songs = _dbContext.Songs
            .Include(x => x.Album)
            .ThenInclude(x => x!.Author)
            .Where(x => x.Album.Author.Name.ToLower() == authorName.Trim().ToLower())
            .Select(x => new SongView(x))
            .ToList<SongView>();

        return songs;
    }

    public List<SongView> GetSongsByAlbum(string albumName)
    {
        var songs = _dbContext.Songs
            .Include(x => x.Album)
            .Where(x => x.Album.Name.ToLower() == albumName.Trim().ToLower())
            .Select(x => new SongView(x))
            .ToList<SongView>();
        
        return songs;
    }

    // public List<SongView> GetSongsByCategory(string subCategoryName)
    // {
    //     var songs = _dbContext.Songs
    //         .Include(x => x.SubCategories)
    //         .Where(x => x.SubCategories == subCategoryName)
    //         .Select(x => new SongView(x))
    //         .ToList<SongView>();
    //
    //     return songs;
    // }
    
    
}