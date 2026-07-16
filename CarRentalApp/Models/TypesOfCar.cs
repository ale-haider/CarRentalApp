using System;
using System.Collections.Generic;

namespace CarRentalApp.Models;

public partial class TypesOfCar
{
    public int Id { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public string? Vin { get; set; }

    public string? LicensePlateNumber { get; set; }

    public int? Year { get; set; }

    public virtual ICollection<CarRentalRecord> CarRentalRecords { get; set; } = new List<CarRentalRecord>();
}
