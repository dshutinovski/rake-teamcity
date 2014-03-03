namespace Project
{
    using Topshelf;

    public static class Program
    {
        public static void Main()
        {
            HostFactory.Run(x =>
            {
                x.Service<Web>(s =>
                {
                    s.ConstructUsing(() => new Web());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();

                x.SetDescription("Web Demo");
                x.SetDisplayName("WebDemo");
                x.SetServiceName("WebDemo");
            });
        }
    }
}