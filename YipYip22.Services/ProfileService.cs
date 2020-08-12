using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YipYip22.Data;
using YipYip22.Models;

namespace YipYip22.Services
{
    public class ProfileService
    {
        private readonly Guid _userId;

        public ProfileService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateProfile(ProfileCreate model)
        {
            var entity =
                new Profile()
                {
                    Id = _userId,
                    ProfileName = model.ProfileName,
                    Phone = model.Phone,
                    Email = model.Email,
                    Rating = model.Rating,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Profiles.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ProfileListItem> ProfileListItems()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Profiles
                        .Where(e => e.ProfileId >= 0)
                        .Select(
                            e =>
                                new ProfileListItem
                                {
                                    ProfileId = e.ProfileId,
                                    ProfileName = e.ProfileName,
                                    Phone = e.Phone,
                                    Email = e.Email,
                                    Rating = e.Rating,
                                }
                        );
                return query.ToArray();
            }
        }
        public ProfileDetail GetProfileById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Profiles
                        .Single(e => e.ProfileId == id);
                return
                    new ProfileDetail
                    {
                        ProfileId = entity.ProfileId,
                        ProfileName = entity.ProfileName,
                        Phone = entity.Phone,
                        Email = entity.Email,
                        Rating = entity.Rating
                    };
            }
        }
        public bool UpdateProfile(ProfileEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Profiles
                        .Single(e => e.ProfileId == model.ProfileId && e.Id == _userId);
                entity.ProfileName = model.ProfileName;
                entity.Phone = model.Phone;
                entity.Email = model.Email;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
