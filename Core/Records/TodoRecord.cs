using System.ComponentModel.DataAnnotations;

namespace Todo.Core.Records;

public record Todo(string Title, string? Description, bool? Done = false) {
    [Key] public Guid Id { get; init; } = Guid.NewGuid();
}