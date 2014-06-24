

using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ChatDemo.Startup1))]

namespace ChatDemo
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.MapSignalR();
        }
    }
}
