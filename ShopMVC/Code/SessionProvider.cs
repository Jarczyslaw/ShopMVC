using ShopMVC.Commons;
using ShopMVC.Commons.Abstraction;
using System.Web;
using System.Web.SessionState;

namespace ShopMVC.Code
{
    public class SessionProvider : ISessionProvider
    {
        public HttpSessionState Session => HttpContext.Current.Session;

        public void Abandon()
        {
            Session.Abandon();
        }

        public T Get<T>(string key)
        {
            return (T)Session[key];
        }

        public void Set<T>(string key, T value)
        {
            Session[key] = value;
        }
    }
}