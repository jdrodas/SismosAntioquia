using SismosAntioquiaAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace SismosAntioquiaAPI.Services
{
    public class RegionesService
    {
        private readonly IMongoCollection<Region> _regionesCollection;

        public RegionesService(
        IOptions<SismosAntioquiaDatabaseSettings> sismosAntioquiaDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                sismosAntioquiaDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                sismosAntioquiaDatabaseSettings.Value.DatabaseName);

            _regionesCollection = mongoDatabase.GetCollection<Region>(
                sismosAntioquiaDatabaseSettings.Value.RegionesCollectionName);
        }

        public async Task<List<Region>> GetAsync() =>
            await _regionesCollection.Find(_ => true).ToListAsync();

        public async Task<Region?> GetAsync(string id) =>
            await _regionesCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Region newRegion) =>
            await _regionesCollection.InsertOneAsync(newRegion);

        public async Task UpdateAsync(string id, Region updatedRegion) =>
            await _regionesCollection.ReplaceOneAsync(x => x.Id == id, updatedRegion);

        public async Task RemoveAsync(string id) =>
            await _regionesCollection.DeleteOneAsync(x => x.Id == id);
    }
}
