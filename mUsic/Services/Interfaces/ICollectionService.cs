using mUsic.Services.Views;

namespace mUsic.Services.Interfaces;

public interface ICollectionService
{
    public List<SongView> GetSongByCollection(string collectionName);
}