using Microsoft.AspNetCore.Mvc;
using mUsic.Services.Interfaces;
using mUsic.Services.Views;

namespace mUsic.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorsController : ControllerBase
{
    private IAuthorService _authorService;

    public AuthorsController(IAuthorService songService)
    {
        _authorService = songService;
    }

    [HttpGet("{authorName}")]
    public IEnumerable<SongView> Get([FromRoute]string authorName)
    {
        return _authorService.GetSongByAuthor(authorName);
    }
    
}