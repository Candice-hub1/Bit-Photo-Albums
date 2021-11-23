using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BIT__PHOTO_ALBUMS.Models;

namespace BIT__PHOTO_ALBUMS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BIT__PHOTO_ALBUMS.Models.Photo> Photo { get; set; }
    }
}
