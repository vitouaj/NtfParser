
namespace NtfParser;

public class NotificationChannel : INotifcationChannel
{
    public ChannelType Value { get; private set; }

    public void SetValue(ChannelType channelType)
    {
        Value = channelType;
    }

    public List<NotificationChannel> FromNotificationTitle(NotifcationTitle notifcationTitle)
    {
        List<NotificationChannel> noticationChannels = [];



        return noticationChannels;
    }
}
