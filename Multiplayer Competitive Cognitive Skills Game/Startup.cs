using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Multiplayer_Competitive_Cognitive_Skills_Game.Startup))]
namespace Multiplayer_Competitive_Cognitive_Skills_Game
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
