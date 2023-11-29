using InfluxDB.Client;
using InfluxDB.Client.Linq;
using InfluxDB.Client.Api.Domain;
using SmartFarm.Web.Data.LogModels;

namespace SmartFarm.Web.Services;

public interface ITimeLogger
{
    public List<T> ReadMeasurement<T>(string measurement) where T : Log;
    public void Write<T>(T model, string measurement) where T : Log;
}

public class InfluxLogger: ITimeLogger
{
    private readonly string _token;
    private readonly string _url;
    private const string Bucket = "smart-farm";
    private const string Org = "smart-farm";
    
    
    public InfluxLogger(IConfiguration configuration)
    {
        _token = configuration.GetValue<string>("InfluxDB:Token")!;
        _url = configuration.GetValue<string>("InfluxDB:Url")!;
    }

    public void Write<T>(T model, string measurement) where T: Log
    {
        using var client = new InfluxDBClient(_url, _token);
        model.Time = DateTime.UtcNow;
        model.Measurement = measurement;
        using var writeApi = client.GetWriteApi();
        writeApi.WriteMeasurement(model, WritePrecision.Ns, Bucket, Org);
    }
    
    public List<T> ReadMeasurement<T>(string measurement) where T: Log
    {
        using var client = new InfluxDBClient(_url, _token);
        var apiCall = client.GetQueryApiSync();
        var optimizerSettings =
            new QueryableOptimizerSettings
            {
                DropMeasurementColumn = false,
            };
        var queryable =
            new InfluxDBQueryable<T>(Bucket, Org, apiCall, new DefaultMemberNameResolver(), optimizerSettings);
        return queryable.Where(q => q.Measurement == measurement).ToList();
    }
}