using System.Web.SessionState;

namespace ShopMVC.Commons.Abstraction
{
    public interface ISessionProvider : ICacheProvider
    {
        HttpSessionState Session { get; }
    }
}