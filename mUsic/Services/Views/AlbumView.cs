using Models;

namespace mUsic.Services.Views;

public class AlbumView
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DateOfPublication { get; set; }
    public int DateOfUpload { get; set; }
    public int AuthorId { get; set; }
    
    public AlbumView(Album album)
    {
        Id = album.Id;
        Name = album.Name;
        DateOfPublication = album.DateOfPublication;
        DateOfUpload = album.DateOfUpload;
        AuthorId = album.AuthorId;
    }
}