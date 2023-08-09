namespace TaskManagerSystem;

public class ProjectService
{
    private void AddTask(Task task)
    {
        if (task == null)
        {
            throw new ArgumentNullException(nameof(task));
        }
    }
}
