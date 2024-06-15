namespace Core.Models;

public record Task(
    string Title,
    string? Description,
    string CreatedAtUtc,
    string UpdatedAtUtc
);