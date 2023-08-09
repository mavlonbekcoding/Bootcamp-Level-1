﻿namespace TaskManagerSystem;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<Project> AssignedProjects  { get; set; }
    List<string> Comments { get; set; }
}
