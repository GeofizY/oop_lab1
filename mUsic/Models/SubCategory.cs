﻿namespace Models;

public class SubCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public List<Song> Songs { get; set; } = new();
    
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}