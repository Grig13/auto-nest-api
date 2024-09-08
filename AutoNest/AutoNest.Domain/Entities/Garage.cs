using AutoNest.Domain.Common;

namespace AutoNest.Domain.Entities;

public class Garage : BaseEntity
{
    public string GarageName { get; set; }

    public Address Address { get; set; }
}
