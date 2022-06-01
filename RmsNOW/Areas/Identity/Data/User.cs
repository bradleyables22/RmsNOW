using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RmsNOW.Areas.Identity.Data;

// Add profile data for application users by adding properties to the User class
public class User : IdentityUser
{
    public byte[]? UserPhoto { get; set; }

    [Required]
    public string? FirstName { get; set; }
    
    [Required]
    public string? LastName { get; set; }

    [Required]
    public bool IsActive { get; set; }

    [ForeignKey("CampId")]
    public string? AssignedCamp { get; set; }



}

