// See https://aka.ms/new-console-template for more information
using ProxyPattern;

IDatabaseAccess proxy = new DatabaseAccessProxy("mssql", "access_key");
Console.WriteLine(proxy.Get("select * from User"));