using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MTBTrailReviews.Startup))]
namespace MTBTrailReviews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
