using MongoFramework;

namespace SmartFarm.Web.Data
{
    public class ApplicationMongoContext: MongoDbContext
    {
        public MongoDbSet<WarehouseItem> Warehouse { get; set; } = null!;
        public MongoDbSet<Greenhouse> Greenhouses { get; set; } = null!;
        public MongoDbSet<User> Users { get; set; } = null!;

        public ApplicationMongoContext(IMongoDbConnection connection) : base(connection) { }
    }
}
