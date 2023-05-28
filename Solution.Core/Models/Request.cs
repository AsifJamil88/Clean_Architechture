using System;
using System.Collections.Generic;

namespace Solution.Core.Models;

public partial class Request
{
    public int Id { get; set; }

    public int? RequestFromId { get; set; }

    public int? RequestToId { get; set; }

    public string? Reason { get; set; }

    public DateTime? LastUpdateOn { get; set; }

    public bool? IsApproved { get; set; }

    public virtual Employee? RequestFrom { get; set; }

    public virtual Employee? RequestTo { get; set; }
}
