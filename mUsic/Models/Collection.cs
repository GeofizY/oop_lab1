using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class Collection
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public List<Song> Songs { get; set; } = new();
}