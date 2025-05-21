using NotificationSystem.Decorators;
using NotificationSystem.Factories;
using NotificationSystem.Models;
using NotificationSystem.Observers;
using NotificationSystem.Strategies;

Console.WriteLine("Notification system");

var chanel = new Chanel("Youtube");
ISender sender = new EmailSender();
sender = new EncryptionSenderDecorator(sender);
sender = new LoggingNotificationDecorator(sender);
chanel.SetSender(sender);
chanel.SetFormater(new PromoFormat());

INotificationFactory factory = new NotificationFactory();
var notification = factory.CreateNotification(NotificationType.Email, "Notification");
ISubscriber user = new User("Bui Quoc Hao");

chanel.Subscribe(user);

chanel.Subscribe(new User("2"));

chanel.Subscribe(new User("3"));

chanel.SendNotification(notification);