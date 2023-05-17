using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DisplayMounts.Areas.Identity.Data;

// Add profile data for application users by adding properties to the DisplayMountsUser class
public class DisplayMountsUser : IdentityUser
{
    [PersonalData]
    public string Faction { get; set; }
    [PersonalData]
    public string Class { get; set; }
    [PersonalData]
    public string CharacterName { get; set; }
}

