using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Peeps.Models;
using Raven.Client;
using Raven.Client.Embedded;

namespace Peeps
{
    public interface IDb
    {
        Task<IList<Peep>> GetAllPeeps();
    }

    public class Db : IDb
    {
        private static readonly EmbeddableDocumentStore DocumentStore = new EmbeddableDocumentStore
        {
            DataDirectory = "~/App_Data/RavenDB"
        };

        public Task<IList<Peep>> GetAllPeeps()
        {
            using (var session = DocumentStore.OpenAsyncSession())
            {
                return session.Query<Peep>().ToListAsync();
            }
        }

        internal static IDocumentSession GetSession()
        {
            return DocumentStore.OpenSession();
        }

        public static void Initialize()
        {
            DocumentStore.Initialize();
        }

        public static void Shutdown()
        {
            DocumentStore.Dispose();
        }
    }
}