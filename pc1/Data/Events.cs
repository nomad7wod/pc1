using System;
using System.Collections.Generic;

namespace pc1.Data;

public partial class Events
{
    public int Id { get; set; }

    public int? OrganizerId { get; set; }

    public string EventName { get; set; } = null!;

    public DateTime EventDate { get; set; }

    public string Location { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<EventAttendance> EventAttendance { get; set; } = new List<EventAttendance>();

    public virtual Organizers? Organizer { get; set; }
}
