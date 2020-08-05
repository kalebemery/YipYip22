using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace YipYip22.Data
{ 

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<Owner> Owners { get; set; }
        protected static void SeedAttractionList(ApplicationDbContext context)
        {
            if (!context.Attractions.Any())
            {
                List<Attraction> attractions = new List<Attraction>
                    {
                        new Attraction {
                        AttractionId = 1,
                        Name = "Food & Stuff",
                        Type = "Restaurant / Convenience",
                        AttractionRating = 4,
                        AttractionLocation = Location.DowntownIndy },
                        new Attraction {
                        AttractionId = 2,
                        Name = "Waterpark for Animals",
                        Type = "Amusement",
                        AttractionRating = 2,
                        AttractionLocation = Location.Avon },
                        new Attraction {
                        AttractionId = 3,
                        Name = "Lawn Games Mania",
                        Type = "Amusement",
                        AttractionRating = 5,
                        AttractionLocation = Location.DowntownIndy },
                        new Attraction {
                        AttractionId = 4,
                        Name = "Sailing Lessons",
                        Type = "Adventure",
                        AttractionRating = 3,
                        AttractionLocation = Location.Carmel },
                        new Attraction {
                        AttractionId = 5,
                        Name = "Axe Throwing, But You are The Target",
                        Type = "Amusement",
                        AttractionRating = 1,
                        AttractionLocation = Location.Lawrence },
                        new Attraction {
                        AttractionId = 6,
                        Name = "St. Elmo's",
                        Type = "Eatery",
                        AttractionRating = 5,
                        AttractionLocation = Location.DowntownIndy },
                        new Attraction {
                        AttractionId = 7,
                        Name = "80's Themed Arcade",
                        Type = "Amusement",
                        AttractionRating = 5,
                        AttractionLocation = Location.BroadRipple },
                        new Attraction {
                        AttractionId = 8,
                        Name = "Socially Distant Scavneger Hunt",
                        Type = "Adventure",
                        AttractionRating = 4,
                        AttractionLocation = Location.BroadRipple },
                        new Attraction { AttractionId = 9,
                        Name = "YouTubing Classes",
                        Type = "Education",
                        AttractionRating = 2,
                        AttractionLocation = Location.Fishers },
                        new Attraction { AttractionId = 10,
                        Name = "Bubble Golf",
                        Type = "Amusement / Unnecessary",
                        AttractionRating = 1,
                        AttractionLocation = Location.DowntownIndy },
                }.ToList();
                context.Attractions.AddRange(attractions);
                context.SaveChanges();
            }
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
              .Conventions
              .Remove<PluralizingTableNameConvention>();

            modelBuilder
                .Configurations
                .Add(new IdentityUserLoginConfiguration())
                .Add(new IdentityUserRoleConfiguration());
        }
    }
    public class IdentityUserLoginConfiguration : EntityTypeConfiguration<IdentityUserLogin>
    {
        public IdentityUserLoginConfiguration()
        {
            HasKey(iul => iul.UserId);
        }
    }
    public class IdentityUserRoleConfiguration : EntityTypeConfiguration<IdentityUserRole>
    {
        public IdentityUserRoleConfiguration()
        {
            HasKey(iur => iur.UserId);
        }

    }
}