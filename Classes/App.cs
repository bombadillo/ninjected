namespace $safeprojectname$.Classes
{
    using System;
    using Interfaces;

    public class App : IApp
    {
        private readonly ILog Logger;

        public App(ILog logger)
        {
            Logger = logger;
        }

        public void Run()
        {
        }
    }
}
