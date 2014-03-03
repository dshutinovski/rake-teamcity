namespace Project
{
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseHandler((req, res) => res.WriteAsync("Hello "));
        }
    }
}