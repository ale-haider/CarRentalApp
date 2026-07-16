using System;
using System.Collections.Generic;

namespace CarRentalApp.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Shorname { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
