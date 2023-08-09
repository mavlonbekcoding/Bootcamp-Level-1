namespace TaskManagerSystem;

public class RegisterService
{
    public bool Register(string UserEmail, string UserParol, User user)
    {
        Console.Write("Login:");
        UserEmail = Console.ReadLine();
        Console.Write("Parol:");
        UserParol = Console.ReadLine();

            if ((UserEmail == user.Email) & (UserParol == user.Password))
            {
                Console.WriteLine("Muvaffaqiyatli ro'yxatdan o'tdingiz davom eting:");
                return true;
            }

            else
            {
                Console.WriteLine("Kiritilgan ma'lumot xato!");
                return false;
            }
    }
}
