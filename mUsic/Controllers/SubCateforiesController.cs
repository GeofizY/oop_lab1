using Microsoft.AspNetCore.Mvc;
using mUsic.Services.Interfaces;
using mUsic.Services.Views;

namespace mUsic.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private ISubCategoryService _subCategoryService;

    public CategoriesController(ISubCategoryService songService)
    {
        _subCategoryService = songService;
    }

    [HttpGet("{subCategoryName}")]
    public IEnumerable<SongView> Get([FromRoute]string subCategoryName)
    {
        return _subCategoryService.GetSongBySubCategory(subCategoryName);
    }
    
}