using NtfParser.Models;

var text1 = "[BE][FE][Urgent][BE][Gaming][QA] there is error";
var title = new NotifcationTitle(text1);
var channels = title.GetChannelsFromTitle();
Print(channels, text1);


static void Print(HashSet<NotificationChannel> channels, string originTitle)
{
    Console.WriteLine($"Input \"{originTitle}\"");
    Console.Write($"Receive channels: ");
    foreach (var ch in channels)
    {
        Console.Write(ch.Value.ToString() + ", ");
    }
    Console.WriteLine();
}