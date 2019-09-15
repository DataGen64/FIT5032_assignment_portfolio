using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIT5032_AssignmentPortfolio_FlyBook.Startup))]
namespace FIT5032_AssignmentPortfolio_FlyBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
