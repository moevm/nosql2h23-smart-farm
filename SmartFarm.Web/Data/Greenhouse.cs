namespace SmartFarm.Web.Data;

public class Greenhouse
{
    public string Id { get; set; } = null!;
    public int Number { get; set; }
    public string Street { get; set; } = null!;
    public List<int>? TeamIds { get; set; }
    public float Temperature { get; set; }
    public float IlluminationDegree { get; set; }
    public string AdditionalInfo { get; set; } = null!;
    public GreenhouseStatus Status { get; set; }
    public List<Plant>? Plants { get; set; }
}

public class Plant
{
    public string Type { get; set; } = null!;
    public string Sort { get; set; } = null!;
    public int Count { get; set; }
}

public enum GreenhouseStatus
{
    Empty,
    Planted,
    Ready
}