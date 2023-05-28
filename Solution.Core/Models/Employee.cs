using System;
using System.Collections.Generic;

namespace Solution.Core.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ManagerId { get; set; }

    public string? UserId { get; set; }

    public virtual ICollection<Employee> InverseManager { get; set; } = new List<Employee>();

    public virtual Employee? Manager { get; set; }

    public virtual ICollection<Request> RequestRequestFroms { get; set; } = new List<Request>();

    public virtual ICollection<Request> RequestRequestTos { get; set; } = new List<Request>();

    public virtual AspNetUser? User { get; set; }
}
