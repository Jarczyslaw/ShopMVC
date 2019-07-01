using System;

namespace ShopMVC.Helpers
{
    public class DisposableHelper : IDisposable
    {
        private Action end;

        public DisposableHelper(Action begin, Action end)
        {
            this.end = end;
            begin?.Invoke();
        }

        public void Dispose()
        {
            end?.Invoke();
        }
    }
}