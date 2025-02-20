using System.Collections.Generic;
using System.Threading.Tasks;
using Raven.Client.Documents.Session;

namespace dotnetcore_webapi_and_ravendb.Contracts
{
    public interface IRavenDatabaseProvider
    {
        Task CreateEntity<T>(T entity);
        Task UpdateEntity<T>(string entityId, T entity);
        Task DeleteEntity(string entityId);
        Task<T> GetEntity<T>(string entityId);
        Task<List<T>> GetEntities<T>();
        Task<bool> IsEntityExists(string entityId);
        void EnsureDatabaseExists(string database = null, bool createDatabaseIfNotExists = true);
        Task<IAsyncDocumentSession> GetSession();
        Task CommitAsync(IAsyncDocumentSession session);
    }
}
