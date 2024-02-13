namespace NtfParser;

public interface INotifcationChannel
{
    List<NotificationChannel> FromNotificationTitle(NotifcationTitle notifcationTitle);
}
