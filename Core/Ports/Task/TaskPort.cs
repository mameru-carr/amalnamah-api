namespace Core.Ports.Task;

public interface TaskPort
{
    Models.Task CreateTask(Models.Task task);
}