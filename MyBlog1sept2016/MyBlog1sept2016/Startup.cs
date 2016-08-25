using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBlog1sept2016.Startup))]
namespace MyBlog1sept2016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
