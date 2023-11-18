using mUsic.Services.Views;

namespace mUsic.Services.Interfaces;

public interface ISubCategoryService
{
    public List<SongView> GetSongBySubCategory(string subCategoryName);
}