using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class Song
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Duration { get; set; }
    
    public int AlbumId { get; set; }
    public Album? Album { get; set; }

    public List<Collection> Collections { get; set; } = new();
    public List<SubCategory> SubCategories { get; set; } = new();

}