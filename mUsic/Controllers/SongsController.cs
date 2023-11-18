using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using mUsic.Services.Interfaces;
using mUsic.Services.Views;

namespace mUsic.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SongsController : ControllerBase
{
   private ISongService _songService;

   public SongsController(ISongService songService)
   {
      _songService = songService;
   }
   
   [HttpGet]
   public IEnumerable<SongView> Get()
   {
      return _songService.GetSongs();
   }
   
   
   [HttpGet("{songName}")]
   public IEnumerable<SongView> Get([FromRoute]string songName)
   {
      return _songService.GetSongs(songName);
   }

   [HttpGet("[action]/{authorName}")]
   public IEnumerable<SongView> GetByAuthorName([FromRoute]string authorName)
   {
      return _songService.GetSongsByAuthor(authorName);
   }
   
   [HttpGet("[action]/{albumName}")]
   public IEnumerable<SongView> GetByAlbumName([FromRoute]string albumName)
   {
      return _songService.GetSongsByAlbum(albumName);
   }
   
}