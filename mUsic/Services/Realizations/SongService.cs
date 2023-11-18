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
    
    // var albums = _dbContext.Albums
    //     .Include(a => a.Songs)
    //     .Where(a => a.AuthorId == author.Id);
    //
    // List<SongView> songs = new List<SongView>();
    //
    // foreach (var album in albums)
    // {
    //     foreach (var song in album.Songs)
    //     {
    //         songs.Add(new SongView(song));
    //     }
    // }
    //
    // return songs;
}