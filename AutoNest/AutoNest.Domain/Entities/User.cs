using AutoNest.Domain.Common;

namespace AutoNest.Domain.Entities;

public class User : BaseEntity
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string ContactNumber { get; set; } = default!;

    public Car Car { get; set; } = default!;
    public Address? Address { get; set; } = default!;

}
