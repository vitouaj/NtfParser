namespace NtfParser.Models.Abstracts;

public interface INotificationTitle
{
    HashSet<NotificationChannel> GetChannelsFromTitle();
}
