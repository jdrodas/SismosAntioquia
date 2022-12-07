using SismosAntioquiaAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace SismosAntioquiaAPI.Services
{
    public class SismosService
    {
        private readonly IMongoCollection<Sismo> _sismosCollection;

        public SismosService(
        IOptions<SismosAntioquiaDatabaseSettings> sismosAntioquiaDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                sismosAntioquiaDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                sismosAntioquiaDatabaseSettings.Value.DatabaseName);

            _sismosCollection = mongoDatabase.GetCollection<Sismo>(
                sismosAntioquiaDatabaseSettings.Value.SismosCollectionName);
        }

        public async Task<List<Sismo>> GetAsync() =>
    await _sismosCollection.Find(_ => true).ToListAsync();

        public async Task<Sismo?> GetAsync(string id) =>
            await _sismosCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Sismo newSismo) =>
            await _sismosCollection.InsertOneAsync(newSismo);

        public async Task UpdateAsync(string id, Sismo updatedSismo) =>
            await _sismosCollection.ReplaceOneAsync(x => x.Id == id, updatedSismo);

        public async Task RemoveAsync(string id) =>
            await _sismosCollection.DeleteOneAsync(x => x.Id == id);
    }
}
