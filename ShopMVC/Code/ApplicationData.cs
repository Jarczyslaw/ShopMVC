using System.Web;

namespace ShopMVC.Code
{
    public class ApplicationData
    {
        private readonly HttpApplicationState application;
        private readonly object sync = new object();

        public ApplicationData(HttpApplicationState application)
        {
            this.application = application;
        }

        public int SessionsCount
        {
            get => (int)application[nameof(SessionsCount)];
            set => application[nameof(SessionsCount)] = value;
        }

        public void ResetSessions()
        {
            lock (sync)
            {
                SessionsCount = 0;
            }
        }

        public int AddSession()
        {
            lock (sync)
            {
                SessionsCount++;
                return SessionsCount;
            }
        }

        public int RemoveSession()
        {
            lock (sync)
            {
                SessionsCount--;
                return SessionsCount;
            }
        }
    }
}