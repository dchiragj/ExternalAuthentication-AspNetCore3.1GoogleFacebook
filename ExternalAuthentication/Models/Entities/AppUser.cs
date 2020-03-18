﻿
using Microsoft.AspNetCore.Identity;

namespace ExternalAuthentication.Models.Entities
{
    // Add profile data for application users by adding properties to this class
  public class AppUser : IdentityUser
  {
    // Extended Properties
    public string FirstName { get; set; }

    public string LastName { get; set; }
    public long? FacebookId { get; set; }
    public long? GoogleId { get; set; }
    public string PictureUrl { get; set; }
  }
}
