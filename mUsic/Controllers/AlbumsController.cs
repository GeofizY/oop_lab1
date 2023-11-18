using Microsoft.AspNetCore.Mvc;
using mUsic.Services.Interfaces;
using mUsic.Services.Views;

namespace mUsic.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlbumsController : ControllerBase
{
    private IAlbumService _albumService;

    public AlbumsController(IAlbumService songService)
    {
        _albumService = songService;
    }

    // [HttpGet("{albumName}")]
    // public IEnumerable<SongView> Get([FromRoute]string albumName)
    // {
    //     return _albumService.GetSongByAlbum(albumName);
    // }
    
}