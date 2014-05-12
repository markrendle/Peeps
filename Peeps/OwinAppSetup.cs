using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Simple.Owin.Static;
using Simple.Web;

namespace Peeps
{
	using UseAction = Action<Func<IDictionary<string, object>, Func<IDictionary<string, object>, Task>, Task>>;

    public class OwinAppSetup
    {
        public static void Setup(UseAction use)
        {
            new SeedData().Seed();
            use(Statics.AddFileAlias("/index.html", "/").AddFolder("/content").AddFolder("/scripts").AddFolder("/fonts"));
            use(Application.Run);
        }
    }
}