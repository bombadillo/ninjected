﻿namespace $safeprojectname$
{
    using Interfaces;

    class $safeprojectname$
    {
        static void Main(string[] args)
        {
            CompositionRoot.Wire(new ApplicationModule());

            var app = CompositionRoot.Resolve<IApp>();

            app.Run();
        }
    }
}
