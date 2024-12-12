using System;

public class Song
{
    private string name; 
    private string author;
    public Song prev; // связь с предыдущей песней в списке

    
    public void SetName(string name)
    {
        this.name = name;
    }

   
    public void SetAuthor(string author)
    {
        this.author = author;
    }

   
    public void SetPrev(Song prev)
    {
        this.prev = prev;
    }

    
    public string Title()
    {
        return $"{name} - {author}";
    }

    // методкоторый сравнивает между собой два объекта песни
    public override bool Equals(object obj)
    {
        if (obj is Song otherSong)
        {
            return this.name == otherSong.name && this.author == otherSong.author;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return (name + author).GetHashCode();
    }
}
