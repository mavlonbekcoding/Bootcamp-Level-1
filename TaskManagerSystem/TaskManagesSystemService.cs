namespace TaskManagerSystem;

public class TaskManagerSystemService
{
    public void CreateProject(Project project)
    {
        if (project == null)
        {
            throw new ArgumentNullException(nameof(project));
        }
    }

    public void CreateTask(Project project, Task task)
    {

    }
}

