namespace CommToolMauiApp.Model;

public record Item(string Title)
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateTime CreationDate { get; init; } = DateTime.Now;
}
