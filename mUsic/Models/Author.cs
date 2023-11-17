﻿namespace Models;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Album>? Albums = new();
}