namespace SismosAntioquiaAPI.Models
{
    public class SismosAntioquiaDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string SismosCollectionName { get; set; } = null!;

        public string RegionesCollectionName { get; set; } = null!;
    }
}
