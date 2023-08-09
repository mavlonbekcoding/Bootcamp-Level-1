namespace TaskManagerSystem;

public class Project
{
    public int Id { get; set; } 
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Task> Tasks { get; set; }
}
