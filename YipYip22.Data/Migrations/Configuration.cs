namespace YipYip22.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<YipYip22.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "YipYip22.Data.ApplicationDbContext";
        }

        protected override void Seed(YipYip22.Data.ApplicationDbContext context)
        {
            context.Attractions.AddOrUpdate(x => x.AttractionId,
                        new Attraction
                        {
                            AttractionId = 1,
                            Name = "Food & Stuff",
                            Type = "Restaurant / Convenience",
                            AttractionRating = 4,
                            AttractionLocation = Location.DowntownIndy
                        },
                        new Attraction
                        {
                            AttractionId = 2,
                            Name = "Waterpark for Animals",
                            Type = "Amusement",
                            AttractionRating = 2,
                            AttractionLocation = Location.Avon
                        },
                        new Attraction
                        {
                            AttractionId = 3,
                            Name = "Lawn Games Mania",
                            Type = "Amusement",
                            AttractionRating = 5,
                            AttractionLocation = Location.DowntownIndy
                        },
                        new Attraction
                        {
                            AttractionId = 4,
                            Name = "Sailing Lessons",
                            Type = "Adventure",
                            AttractionRating = 3,
                            AttractionLocation = Location.Carmel
                        },
                        new Attraction
                        {
                            AttractionId = 5,
                            Name = "Axe Throwing, But You are The Target",
                            Type = "Amusement",
                            AttractionRating = 1,
                            AttractionLocation = Location.Lawrence
                        },
                        new Attraction
                        {
                            AttractionId = 6,
                            Name = "St. Elmo's",
                            Type = "Eatery",
                            AttractionRating = 5,
                            AttractionLocation = Location.DowntownIndy
                        },
                        new Attraction
                        {
                            AttractionId = 7,
                            Name = "80's Themed Arcade",
                            Type = "Amusement",
                            AttractionRating = 5,
                            AttractionLocation = Location.BroadRipple
                        },
                        new Attraction
                        {
                            AttractionId = 8,
                            Name = "Socially Distant Scavneger Hunt",
                            Type = "Adventure",
                            AttractionRating = 4,
                            AttractionLocation = Location.BroadRipple
                        },
                        new Attraction
                        {
                            AttractionId = 9,
                            Name = "YouTubing Classes",
                            Type = "Education",
                            AttractionRating = 2,
                            AttractionLocation = Location.Fishers
                        },
                        new Attraction
                        {
                            AttractionId = 10,
                            Name = "Bubble Golf",
                            Type = "Amusement / Unnecessary",
                            AttractionRating = 1,
                            AttractionLocation = Location.DowntownIndy
                        },
                        new Attraction
                        {
                            AttractionId = 11,
                            Name = "Underground Tunnels of Speedway",
                            Type = "Adventure",
                            AttractionRating = 3,
                            AttractionLocation = Location.Speedway
                        },
                        new Attraction
                        {
                            AttractionId = 12,
                            Name = "Swim with Sharks",
                            Type = "Adventure",
                            AttractionRating = 5,
                            AttractionLocation = Location.FountainSquare
                        },
                        new Attraction
                        {
                            AttractionId = 13,
                            Name = "Skydive Plainfield",
                            Type = "Adventure",
                            AttractionRating = 4,
                            AttractionLocation = Location.Plainfield
                        },
                        new Attraction
                        {
                            AttractionId = 14,
                            Name = "Totino's Buffet",
                            Type = "Restaurant",
                            AttractionRating = 4,
                            AttractionLocation = Location.BeachGrove
                        },
                        new Attraction
                        {
                            AttractionId = 15,
                            Name = "Fly Swatting",
                            Type = "Adventure",
                            AttractionRating = 1,
                            AttractionLocation = Location.Greenwood
                        },
                        new Attraction
                        {
                            AttractionId = 16,
                            Name = "Life-Size Board Games",
                            Type = "Amusement",
                            AttractionRating = 5,
                            AttractionLocation = Location.Brownsburg
                        }
                        );
        }
    }
}
