using MainApp.Models;

namespace MainApp.Services;

public class UserService
{
    private readonly List<User> _users = [];

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public IEnumerable<User> GetUsers()
    {
        return _users;
    }
}