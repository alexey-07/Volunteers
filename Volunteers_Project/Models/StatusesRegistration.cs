using System;
using System.Collections.Generic;

namespace Volunteers_Project.Models;

public partial class StatusesRegistration
{
    public int Id { get; set; }

    public string NameStatuses { get; set; } = null!;

    public virtual ICollection<RegistrationVolunteer> RegistrationVolunteers { get; set; } = new List<RegistrationVolunteer>();
}
