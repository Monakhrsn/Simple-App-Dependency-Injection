using MainApp.Models;
using MainApp.Services;

namespace MainApp.Dialogs;

public class AdminMenuDialogs
{
    private readonly UserService _userService;

    public AdminMenuDialogs(UserService userService)
    {
        _userService = userService;
    }


    public void CreateUserOption()
    {
        var user = new User();
        
        Console.WriteLine("ADMIN - ADD USER");
        Console.WriteLine("Enter Name: ");
        user.Name = Console.ReadLine()!;
        
        _userService.AddUser(user);

        Console.ReadKey();
        Console.WriteLine();
    }

    public void ShowAllUsersOption()
    {
        var users = _userService.GetUsers();
        
        Console.WriteLine("ADMIN - VIEW ALL USERS");
        foreach (var user in users)
        {
            Console.WriteLine(user.Name);
        }
    }
}