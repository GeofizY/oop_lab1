using Models;

namespace mUsic.Services.Views;

public class SongView
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Duration { get; set; }

    public SongView(Song song)
    {
        Id = song.Id;
        Name = song.Name;
        Duration = song.Duration;
    }
}