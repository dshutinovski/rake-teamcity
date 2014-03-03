namespace Project
{
    using System;
    using Microsoft.Owin.Hosting;

    public class Web
    {
        private IDisposable _App;

        public void Start()
        {
            _App = WebApp.Start<Startup>("http://localhost:5000");
        }

        public void Stop()
        {
            _App.Dispose();
        }
    }
}