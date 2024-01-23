// See https://aka.ms/new-console-template for more information

using BuilderPattern;

Console.WriteLine("Builder design pattern");
NotificationBuilder builder = new NotificationBuilder();
Notification notification = builder.AddNotice("asdfasdf")
                                    .AddContent("asdfadsf")
                                    .AddEmailAddress("asdfadsf")
                                    .AddReceiver(123)
                                    .AddSender(333)
                                    .Build();

System.Console.WriteLine(notification);