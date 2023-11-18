using Microsoft.EntityFrameworkCore;
using mUsic.Database;
using mUsic.Services.Interfaces;
using mUsic.Services.Views;

namespace mUsic.Services.Realizations;

public class AlbumService : IAlbumService
{
    private MusicDbContext _dbContext;

    public AlbumService(MusicDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public List<SongView> GetSongByAlbum(string albumName)
    {
        var album = _dbContext.Albums.Include(album => album.Songs)
            .FirstOrDefault(x => x.Name == albumName);

        if (albumName == null)
        {
            return new List<SongView>();
        }

        var songs = album.Songs.Select(x => new SongView(x)).ToList();
        return songs;

    }
    
}