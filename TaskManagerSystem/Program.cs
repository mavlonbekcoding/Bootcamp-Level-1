using Microsoft.Win32;
using TaskManagerSystem;

TaskManagerSystemService  taskManagerSystemService = new TaskManagerSystemService();

User user = new User();
user.UserName = "Mavlonbek";
user.Email = "mavlonbekcoding@gmail.com";
user.Password = "Mavlonbek0405";

RegisterService service = new RegisterService();
service.Register("mavlonbekcoding@gmail.com","Mavlonbek0405",user);


   