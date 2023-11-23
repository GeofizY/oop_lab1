using Microsoft.EntityFrameworkCore;
using mUsic.Database;
using mUsic.Services.Interfaces;
using mUsic.Services.Views;

namespace mUsic.Services.Realizations;

public class SubCategoryService : ISubCategoryService
{
    private MusicDbContext _dbContext;

    public SubCategoryService(MusicDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public List<SongView> GetSongBySubCategory(string subCategoryName)
    {
        var subCategory = _dbContext.SubCategories.Include(subCategory => subCategory.Songs)
            .FirstOrDefault(x => x.Name.ToLower() == subCategoryName.Trim().ToLower());

        if (subCategory == null)
        {
            return new List<SongView>();
        }

        var songs = subCategory.Songs.Select(x => new SongView(x)).ToList();
        return songs;

    }
    
}