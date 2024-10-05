using System;
using System.Collections.Generic;

namespace pc1.Data;

public partial class Attendees
{
    public int Id { get; set; }

    public string AttendeeName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public DateTime? RegisteredAt { get; set; }

    public virtual ICollection<EventAttendance> EventAttendance { get; set; } = new List<EventAttendance>();
}
