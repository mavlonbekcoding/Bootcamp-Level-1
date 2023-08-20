using N27_HT1;

public class Program
{
    static void Main(string[] args)
    {
        UserService userService = new UserService();

        Console.WriteLine("Users:");
        foreach (var user in userService.GetUsers())
        {
            Console.WriteLine($"ID: {user.Id}, Email: {user.EmailAddress}, Admin: {user.IsAdmin}");
        }
    }
}