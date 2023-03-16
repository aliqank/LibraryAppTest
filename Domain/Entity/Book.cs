using System.Text.Json.Serialization;

namespace Domain.Entity;

public class Book
{ 
    public int Id { get; set; }
    
    public string Title { get; set; }
    public bool IsAvailable { get; set; } = true;
    public long UserId { get; set; }

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Title)}: {Title}, {nameof(IsAvailable)}: {IsAvailable}, {nameof(UserId)}: {UserId}";
    }
}