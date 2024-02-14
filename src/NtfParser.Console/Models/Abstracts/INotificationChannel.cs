namespace NtfParser.Models.Abstracts;

public interface INotificationChannel
{
    NotificationChannel FromString(string text);
}
