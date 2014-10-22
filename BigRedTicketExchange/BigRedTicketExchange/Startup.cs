using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigRedTicketExchange.Startup))]
namespace BigRedTicketExchange
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
