using Models;
using mUsic.Services.Views;

namespace mUsic.Services.Interfaces;

public interface ISongService
{
    public List<SongView> GetSongs();
    public List<SongView> GetSongs(string authorName);
}