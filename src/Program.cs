using NtfParser.Models;

var text1 = "[BE][FE][Urgent][BE][Gaming][QA] there is error";
var title = new NotifcationTitle(text1);
var channels = title.GetChannelsFromTitle();
foreach (var ch in channels)
{
    Console.WriteLine(ch.Value.ToString());
}