// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

Console.WriteLine("Hello, World!");

// Chain of middlewares -> 
// 1. Authentication Middleware: check request has token
// 2. Authorization Middleware: check token contains 'token'
// 3. Check permission of user from token: check token contains 'create'

BaseHandler handler = new ValidateUserNameHandler();
handler.SetNext(new ValidatePasswordHandler())
    .SetNext(new ValidateUserRoleHandler())
    .SetNext(new ValidateUserPermissionHandler());

bool isValidUser = handler.SecurityHandler(new User()
{
    UserName = "username",
    Password = "password",
    Role = "admin",
    Permission = "create/update/delete/read"
});

System.Console.WriteLine(isValidUser);