namespace Models;

public class Album
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DateOfPublication { get; set; }
    public int DateOfUpload { get; set; }

    public List<Song> Songs = new();
    
    public int AuthorId { get; set; }
    public Author? Author { get; set; }
}