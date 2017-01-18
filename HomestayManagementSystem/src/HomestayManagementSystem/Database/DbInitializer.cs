using System.Linq;

namespace HomestayManagementSystem.Database
{
    public static class DbInitializer
    {
        public static void Initialize(HomestayContext context)
        {
            //var users1 = new List<User>();

            //for (int i = 1; i < 100000; i++)
            //{
            //    users1.Add(new User()
            //    {
            //        FirstName = "Test",
            //        LastName = i.ToString(),
            //        LoginId = "test" + i,
            //        Password = "1234!",
            //        Permission = context.Permissions.FirstOrDefault(x => x.Name == "User"),
            //        UserSiteLocations = new List<UserSiteLocation>()
            //        {
            //            new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "Loy") },
            //            new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "KGIC") },
            //            new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "KGIC") }
            //        },
            //        CreatedDate = DateTime.Now
            //    });
            //}
            //context.Users.AddRange(users1);
            //context.SaveChanges();

            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            if (context.Permissions.Any())
                return;

            var dummyData = new DummyData(context);
            dummyData.AddPermissions();
            dummyData.AddSites();
            dummyData.AddUsers();
            dummyData.AddHomestays();
            dummyData.AddStudents();
            dummyData.AddHomestayStudents();
        }
    }
}
