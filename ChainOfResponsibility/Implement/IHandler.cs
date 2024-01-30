namespace ChainOfResponsibility;

public interface IHandler
{
    bool SecurityHandler(User user);
}

public abstract class BaseHandler : IHandler
{
    private BaseHandler? _next;

    public BaseHandler SetNext(BaseHandler handler)
    {
        _next = handler;
        return _next;
    }

    protected bool Next(User user)
    {
        if (_next == null)
        {
            return true;
        }

        return _next.SecurityHandler(user);
    }

    public abstract bool SecurityHandler(User user);
}

public class ValidateUserNameHandler : BaseHandler
{
    public override bool SecurityHandler(User user)
    {
        if (string.IsNullOrEmpty(user.UserName))
        {
            System.Console.WriteLine("User's password is empty");
            return false;
        }

        if (user.UserName != "username")
        {
            System.Console.WriteLine("User's username is incorrect");
            return false;
        }

        Console.WriteLine("User's username is valid");
        return Next(user);
    }
}

public class ValidatePasswordHandler : BaseHandler
{
    public override bool SecurityHandler(User user)
    {
        if (string.IsNullOrEmpty(user.Password))
        {
            System.Console.WriteLine("User's password is empty");
            return false;
        }

        if (user.Password != "password")
        {
            System.Console.WriteLine("User's password is incorrect");
            return false;
        }

        Console.WriteLine("User's password is valid");
        return Next(user);
    }
}


public class ValidateUserRoleHandler : BaseHandler
{
    public override bool SecurityHandler(User user)
    {
        if (string.IsNullOrEmpty(user.Role))
        {
            System.Console.WriteLine("User's role is empty");
            return false;
        }

        if (user.Role.Trim().ToLower() != "admin")
        {
            System.Console.WriteLine("User's role is incorrect");
            return false;
        }

        Console.WriteLine("User's role is valid");

        return Next(user);
    }
}

public class ValidateUserPermissionHandler : BaseHandler
{
    public override bool SecurityHandler(User user)
    {
        if (string.IsNullOrEmpty(user.Permission))
        {
            System.Console.WriteLine("User's role is empty");
            return false;
        }

        if (!user.Permission.Contains("create"))
        {
            System.Console.WriteLine("User's role is incorrect");
            return false;
        }

        Console.WriteLine("User's permission is valid");
        return Next(user);
    }
}