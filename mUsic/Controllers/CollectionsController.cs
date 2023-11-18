using Microsoft.AspNetCore.Mvc;
using mUsic.Services.Interfaces;
using mUsic.Services.Views;

namespace mUsic.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CollectionsController : ControllerBase
{
    private ICollectionService _collectionService;

    public CollectionsController(ICollectionService songService)
    {
        _collectionService = songService;
    }

    [HttpGet("{collectionName}")]
    public IEnumerable<SongView> Get([FromRoute]string collectionName)
    {
        return _collectionService.GetSongByCollection(collectionName);
    }
    
}