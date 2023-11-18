using mUsic.Services.Views;

namespace mUsic.Services.Interfaces;

public interface IAuthorService
{
    public List<SongView> GetSongByAuthor(string authorName);
}