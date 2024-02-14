using System.Text.RegularExpressions;
using NtfParser.Models.Abstracts;

namespace NtfParser.Models;

public class NotifcationTitle : INotificationTitle
{
    public NotifcationTitle(string text)
    {
        Value = text;
    }
    private HashSet<NotificationChannel> Channels { get; } = new();
    public string Value { get; set; } = string.Empty;
    public HashSet<NotificationChannel> GetChannelsFromTitle()
    {
        var pattern = @"\[(.*?)\]";
        var matches = Regex.Matches(Value, pattern);
        foreach (Match match in matches)
        {
            string valueInsideBrackets = match.Groups[1].Value;
            var channel = new NotificationChannel().FromString(valueInsideBrackets);
            if (channel.Value != Tag.UNKNOWN)
                Channels.Add(channel);
        }
        return Channels;
    }
}
