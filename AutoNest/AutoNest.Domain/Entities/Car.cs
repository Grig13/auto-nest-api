
namespace AutoNest.Domain.Entities;

public class Car
{
    public string CarBrand { get; set; } = default!;
    public string ModelName { get; set; } = default!;
    public string YearOfManufacture { get; set; } = default!;
    public int HorsePower { get; set; } = default!;
    public string EngineId { get; set; } = default!;
    public string EngineCapacity { get; set; } = default!;
    public string? VIN { get; set; }

}
