// using Microsoft.EntityFrameworkCore;
// using mUsic.Database;
// using mUsic.Services.Interfaces;
// using mUsic.Services.Views;
//
// namespace mUsic.Services.Realizations;
//
// public class AuthorService : IAuthorService
// {
//     private MusicDbContext _dbContext;
//
//     public AuthorService(MusicDbContext dbContext)
//     {
//         _dbContext = dbContext;
//     }
//     
//     public List<SongView> GetSongByAuthor(string authorName)
//     {
//         return _dbContext.Authors
//             .Where(x => x.Name.ToLower() == authorName.ToLower())
//             .Select(x => new SongView(x))
//             .ToList<SongView>();
//     }
//     
// }