using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PeriferiaIT.Api.Startup))]

namespace PeriferiaIT.Api
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
