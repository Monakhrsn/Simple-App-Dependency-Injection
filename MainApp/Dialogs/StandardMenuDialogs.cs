using MainApp.Models;
using MainApp.Services;

namespace MainApp.Dialogs;

public class StandardMenuDialogs
{
    private readonly UserService _userService;

    public StandardMenuDialogs(UserService userService)
    {
        _userService = userService;
    }
    public void CreateUserOption()
    {
        var user = new User();
        
        Console.WriteLine("STANDARD - ADD USER");
        Console.WriteLine("Enter name: ");
        user.Name = Console.ReadLine()!;
        
        _userService.AddUser(user);

        Console.ReadKey();
        Console.WriteLine();
    }

    public void ShowAllUsersOption()
    {
        var users = _userService.GetUsers();
        
        Console.WriteLine("STANDARD - VIEW ALL USERS");
        
        foreach (var user in users)
        {
            Console.WriteLine(user.Name);
        }
    }
}