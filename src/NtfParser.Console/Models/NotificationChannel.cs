using NtfParser.Models.Abstracts;

namespace NtfParser.Models;

public class NotificationChannel : INotificationChannel
{
    public Tag Value { get; private set; }
    public NotificationChannel(Tag type)
    {
        Value = type;
    }
    public NotificationChannel(){}

    public void SetValue(Tag channelType)
    {
        Value = channelType;
    }

    public NotificationChannel FromString(string text)
    {
        NotificationChannel notificationChannel = new();
        switch(text)
        {
            case "BE":
                notificationChannel.SetValue(Tag.BE);
                break;
            case "FE":
                notificationChannel.SetValue(Tag.FE);
                break;
            case "QA":
                notificationChannel.SetValue(Tag.QA);
                break;
            case "Urgent":
                notificationChannel.SetValue(Tag.URGENT);
                break;
            default:
                break;
        }
        return notificationChannel;
    }


    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        return Value == ((NotificationChannel)obj).Value;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}
