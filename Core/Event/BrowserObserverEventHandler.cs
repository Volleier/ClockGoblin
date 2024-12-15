using Core.Enums;
using Core.Models.WebPage;

namespace Core.Event
{
    public delegate void BrowserObserverEventHandler(BrowserType browserType, Site site);
}
