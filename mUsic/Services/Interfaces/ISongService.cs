using Models;
using mUsic.Services.Views;

namespace mUsic.Services.Interfaces;

public interface ISongService
{
    public List<SongView> GetSongs();
    public List<SongView> GetSongs(string songName);
    public List<SongView> GetSongsByAuthor(string authorName);
}