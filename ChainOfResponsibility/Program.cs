// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

Console.WriteLine("Hello, World!");

// Chain of middlewares -> 
// 1. Authentication Middleware: check request has token
// 2. Authorization Middleware: check token contains 'token'
// 3. Check permission of user from token: check token contains 'create'
IMiddleware authentication = new AuthenticationMiddleware();
IMiddleware authorization = new AuthorizationMiddleware();
IMiddleware permission = new PermissionMiddleware();
authorization.SetNext(permission);
authentication.SetNext(authorization);

authentication.Handle(new Request()
{
    Token = "token_create"
});
