using NtfParser.Models;

namespace NtfParser.Test;

[TestClass]
public class NotificationTitleTest
{
    [TestMethod]
    public void GetChannelsFromTitleEmptyTest()
    {
        var text = string.Empty;
        var channels = new NotifcationTitle(text).GetChannelsFromTitle();
        Assert.IsTrue(channels.Count() == 0);
    }

    [TestMethod]
    public void GetChannelsFromTitleDuplicateTagTest()
    {
        var text = "[BE][FE][Urgent][BE][BE][QA] there is error";
        var channels = new NotifcationTitle(text).GetChannelsFromTitle();
        Assert.IsTrue(channels.Count() == 4);    
    }

    [TestMethod]
    public void GetChannelsFromTitleUnknownTagTest()
    {
        var text = "[Gaming][Dotnet][Car][FE] this is a huge error";
        var channels = new NotifcationTitle(text).GetChannelsFromTitle();
        Assert.AreEqual(channels.Count(), 1);
    }

    [TestMethod]
    public void GetChannelsFromTitleMessyOrder()
    {
        var text = "[Gaming][Dotnet][Car]this is a [BE]huge [FE] error";
        var channels = new NotifcationTitle(text).GetChannelsFromTitle();
        Assert.AreEqual(channels.Count(), 2);
    }

}