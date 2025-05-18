namespace ChainOfResponsibility.Implement;

public interface ISecurityService
{
    bool Authenticate(User user);
}

public class LegacySecurityService : ISecurityService
{
    public readonly List<User> _users = new()
    {
        new User
        {
            UserName = "quochao",
            Password = "password",
            Role = "admin",
            Permission = "create/update/delete/get"
        }
    };

    public bool Authenticate(User user)
    {
        if (!IsUserNameExist(user.UserName))
            return false;
        if (!IsPasswordMatching(user.Password))
            return false;
        if (!IsAuthorize(user.Role))
            return false;
        if (!HasPermission(user.Permission))
            return false;
        return true;
    }

    public bool IsUserNameExist(string userName)
    {
        return userName == "quochao";
    }


    public bool IsPasswordMatching(string userName)
    {
        return userName == "quochao";
    }

    public bool IsAuthorize(string role)
    {
        return role == "admin";
    }

    public bool HasPermission(string permission)
    {
        return permission.Contains("create");
    }
}