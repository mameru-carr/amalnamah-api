using Core.Ports.Task;
using Task = Core.Models.Task;

namespace DatabaseAdapters;

public class ListTaskAdapter: TaskPort
{
    private List<Task> _tasks = new();
    public Task CreateTask(Task task)
    {
        throw new NotImplementedException();
    }
}