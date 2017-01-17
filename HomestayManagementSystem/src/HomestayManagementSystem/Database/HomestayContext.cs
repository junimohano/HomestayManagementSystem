using HomestayManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HomestayManagementSystem.Database
{
    public class HomestayContext : DbContext
    {
        public HomestayContext(DbContextOptions<HomestayContext> options)
            : base(options)
        { }

        public DbSet<LoginHistory> LoginHistorys { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<SiteLocation> SiteLocations { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Homestay> Homestays { get; set; }
        public DbSet<UserSiteLocation> UserSiteLocations { get; set; }
        public DbSet<HomestayContract> HomestayContracts { get; set; }
        public DbSet<HomestayEvaluation> HomestayEvaluations { get; set; }
        public DbSet<HomestayPoliceCheck> HomestayPoliceChecks { get; set; }
        public DbSet<HomestayHouseHold> HomestayHouseHolds { get; set; }
        public DbSet<HomestayStudent> HomestayStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //unique
            modelBuilder.Entity<User>().HasAlternateKey(c => c.LoginId);

            // one to one
            modelBuilder.Entity<Homestay>().HasOne(x => x.CreatedUser).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Homestay>().HasOne(x => x.UpdatedUser).WithMany().OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HomestayEvaluation>().HasOne(x => x.CreatedUser).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<HomestayEvaluation>().HasOne(x => x.UpdatedUser).WithMany().OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HomestayPoliceCheck>().HasOne(x => x.CreatedUser).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<HomestayPoliceCheck>().HasOne(x => x.UpdatedUser).WithMany().OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Student>().HasOne(x => x.CreatedUser).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Student>().HasOne(x => x.UpdatedUser).WithMany().OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HomestayStudent>().HasOne(x => x.CreatedUser).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<HomestayStudent>().HasOne(x => x.UpdatedUser).WithMany().OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>().HasOne(x => x.CreatedUser).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasOne(x => x.UpdatedUser).WithMany().OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserSiteLocation>().HasOne(x => x.CreatedUser).WithMany().OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserSiteLocation>().HasOne(x => x.UpdatedUser).WithMany().OnDelete(DeleteBehavior.Restrict);

            // many to many
            modelBuilder.Entity<HomestayStudent>().HasOne(sh => sh.Student).WithMany(s => s.HomestayStudents).HasForeignKey(sh => sh.StudentId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<HomestayStudent>().HasOne(sh => sh.Homestay).WithMany(h => h.HomestayStudents).HasForeignKey(sh => sh.HomestayId).OnDelete(DeleteBehavior.Restrict);

            // many to many
            modelBuilder.Entity<UserSiteLocation>().HasAlternateKey(x => new { x.UserId, x.SiteLocationId });
            modelBuilder.Entity<UserSiteLocation>().HasOne(us => us.User).WithMany(u => u.UserSiteLocations).HasForeignKey(us => us.UserId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<UserSiteLocation>().HasOne(us => us.SiteLocation).WithMany(sl => sl.UserSiteLocations).HasForeignKey(us => us.SiteLocationId).OnDelete(DeleteBehavior.Cascade);

            //foreach (var entity in modelBuilder.Model.GetEntityTypes())
            //{
            //    entity.Relational().TableName = entity.Name;
            //}
            //modelBuilder.Ignore<StudentHomestay>();
            //modelBuilder.Entity<StudentHomestay>().HasKey(x => new { x.StudentHomestayId, x.StudentId, x.HomestayId });
            //modelBuilder.Entity<StudentHomestay>().Property(x => x.StudentHomestayId).ValueGeneratedOnAdd();

            //modelBuilder.Entity<Homestay>().ToTable(nameof(Homestay));
            //modelBuilder.Entity<HomestayEvaluation>().ToTable(nameof(HomestayEvaluation));
            //modelBuilder.Entity<Permission>().ToTable(nameof(Permission));
            //modelBuilder.Entity<Site>().ToTable(nameof(Site));
            //modelBuilder.Entity<SiteLocation>().ToTable(nameof(SiteLocation));
            //modelBuilder.Entity<Student>().ToTable(nameof(Student));
            //modelBuilder.Entity<StudentHomestay>().ToTable(nameof(StudentHomestay));
            //modelBuilder.Entity<User>().ToTable(nameof(User));
        }
    }
}
