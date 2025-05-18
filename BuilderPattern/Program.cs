// See https://aka.ms/new-console-template for more information

using BuilderPattern;

Console.WriteLine("Builder design pattern");
var builder = new NotificationBuilder();
var notification = builder.AddNotice("asdfasdf")
    .AddContent("asdfadsf")
    .AddEmailAddress("asdfadsf")
    .AddReceiver(123)
    .AddSender(333)
    .Build();

Console.WriteLine(notification);