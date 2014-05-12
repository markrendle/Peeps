using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Peeps.Models;
using Simple.Web;
using Simple.Web.Behaviors;

namespace Peeps
{
    [UriTemplate("/peeps")]
    public class GetPeeps : IGetAsync, IOutput<PeepCollection>
    {
        public async Task<Status> Get()
        {
            var db = new Db();
            Output = new PeepCollection
            {
                Peeps = await db.GetAllPeeps()
            };
            return 200;
        }

        public PeepCollection Output { get; private set; }
    }
}