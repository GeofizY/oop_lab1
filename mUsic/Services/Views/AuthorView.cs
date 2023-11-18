using Models;

namespace mUsic.Services.Views;

public class AuthorView
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public AuthorView(Author author)
    {
        Id = author.Id;
        Name = author.Name;
    }
}