using MongoFramework;

namespace SmartFarm.Web.Data
{
    public class ApplicationMongoContext: MongoDbContext
    {
        public MongoDbSet<TestModel> TestModels { get; set; } = null!;

        public ApplicationMongoContext(IMongoDbConnection connection) : base(connection) { }
    }
}
