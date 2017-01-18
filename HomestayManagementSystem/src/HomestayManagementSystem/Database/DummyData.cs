using System;
using System.Collections.Generic;
using System.Linq;
using HomestayManagementSystem.Models;
using HomestayManagementSystem.Utils;

namespace HomestayManagementSystem.Database
{
    public class DummyData
    {
        private readonly HomestayContext _context;

        public DummyData(HomestayContext context)
        {
            _context = context;
        }

        public void AddPermissions()
        {
            var permissions = new List<Permission>
            {
                new Permission() { Name = "Developer" },
                new Permission() { Name = "Admin" },
                new Permission() { Name = "User" }
            };
            _context.Permissions.AddRange(permissions);
            _context.SaveChanges();
        }

        public void AddSites()
        {
            var sites = new List<Site>
            {
                new Site() { Name = "CAC", FullName = "Cornerstone Academic College", SiteLocations = new List<SiteLocation>
                {
                    new SiteLocation() {Name = "Toronto", Address = string.Empty }
                }},
                  new Site() { Name = "KGIC", FullName = "King George International College", SiteLocations = new List<SiteLocation>
                {
                    new SiteLocation() {Name = "Toronto", Address = string.Empty },
                    new SiteLocation() {Name = "Vancouver", Address = string.Empty },
                    new SiteLocation() {Name = "Victoria", Address = string.Empty },
                    new SiteLocation() {Name = "Surrey", Address = string.Empty }
                }},
                new Site() { Name = "MTI", FullName = "MTI Community College", SiteLocations = new List<SiteLocation>
                {
                    new SiteLocation() {Name = "Vancouver", Address = string.Empty },
                    new SiteLocation() {Name = "Surrey", Address = string.Empty },
                    new SiteLocation() {Name = "North Road", Address = string.Empty },
                    new SiteLocation() {Name = "Chilliwack", Address = string.Empty }
                }},
                new Site() { Name = "PGIC", FullName = "Pacific Gateway International College", SiteLocations = new List<SiteLocation>
                {
                    new SiteLocation() {Name = "Toronto", Address = string.Empty },
                    new SiteLocation() {Name = "Vancouver", Address = string.Empty },
                    new SiteLocation() {Name = "Victoria", Address = string.Empty }
                }},
                new Site() { Name = "SEC-UCCBT", FullName = "Study English In Canada", SiteLocations = new List<SiteLocation>
                {
                    new SiteLocation() {Name = "Toronto", Address = string.Empty },
                    new SiteLocation() {Name = "Vancouver", Address = string.Empty }
                }},
                new Site() { Name = "UIS", FullName = "Urban International School", SiteLocations = new List<SiteLocation>
                {
                    new SiteLocation() {Name = "Toronto", Address = string.Empty }
                }}
            };
            _context.Sites.AddRange(sites);
            _context.SaveChanges();
        }

        public void AddUsers()
        {
            var users = new List<User>
            {
                new User()
                {
                    FirstName = "Administrator", LastName = "", LoginId = "administrator", Password = ConstValue.GetHash("Lrn2017!@#"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "Developer"),
                    UserSiteLocations = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "CAC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "KGIC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "KGIC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Victoria" && x.Site.Name == "KGIC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Surrey" && x.Site.Name == "KGIC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "MTI") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Surrey" && x.Site.Name == "MTI") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "North Road" && x.Site.Name == "MTI") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Chilliwack" && x.Site.Name == "MTI") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "PGIC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "PGIC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Victoria" && x.Site.Name == "PGIC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "SEC-UCCBT") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "SEC-UCCBT") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "UIS") }
                    },
                    CreatedDate = DateTime.Now
                },
                new User()
                {
                    FirstName = "Admin", LastName = "", LoginId = "admin", Password = ConstValue.GetHash("admin!@#$"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "Admin"),
                    UserSiteLocations = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "CAC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "KGIC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "KGIC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Victoria" && x.Site.Name == "KGIC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Surrey" && x.Site.Name == "KGIC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "MTI") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Surrey" && x.Site.Name == "MTI") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "North Road" && x.Site.Name == "MTI") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Chilliwack" && x.Site.Name == "MTI") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "PGIC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "PGIC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Victoria" && x.Site.Name == "PGIC") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "SEC-UCCBT") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "SEC-UCCBT") },
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "UIS") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "CAC", LastName = "Toronto", LoginId = "cactoronto", Password = ConstValue.GetHash("cactoronto"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "CAC") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "KGIC", LastName = "Toronto", LoginId = "kgictoronto", Password = ConstValue.GetHash("kgictoronto"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "KGIC") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "KGIC", LastName = "Vancouver", LoginId = "kgicvancouver", Password = ConstValue.GetHash("kgicvancouver"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "KGIC") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "KGIC", LastName = "Victoria", LoginId = "kgicvictoria", Password = ConstValue.GetHash("kgicvictoria"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Victoria" && x.Site.Name == "KGIC") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "KGIC", LastName = "Surrey", LoginId = "kgicsurrey", Password = ConstValue.GetHash("kgicsurrey"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Surrey" && x.Site.Name == "KGIC") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "MTI", LastName = "Vancouver", LoginId = "mtivancouver", Password = ConstValue.GetHash("mtivancouver"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "MTI") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "MTI", LastName = "Surrey", LoginId = "mtisurrey", Password = ConstValue.GetHash("mtisurrey"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Surrey" && x.Site.Name == "MTI") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "MTI", LastName = "North Road", LoginId = "mtinorthroad", Password = ConstValue.GetHash("mtinorthroad"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "North Road" && x.Site.Name == "MTI") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "MTI", LastName = "Chilliwack", LoginId = "mtichilliwack", Password = ConstValue.GetHash("mtichilliwack"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Chilliwack" && x.Site.Name == "MTI") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "PGIC", LastName = "Toronto", LoginId = "pgictoronto", Password = ConstValue.GetHash("pgictoronto"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "PGIC") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "PGIC", LastName = "Vancouver", LoginId = "pgicvancouver", Password = ConstValue.GetHash("pgicvancouver"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "PGIC") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "PGIC", LastName = "Victoria", LoginId = "pgicvictoria", Password = ConstValue.GetHash("pgicvictoria"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Victoria" && x.Site.Name == "PGIC") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "SEC-UCCBT", LastName = "Toronto", LoginId = "sectoronto", Password = ConstValue.GetHash("sectoronto"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "SEC-UCCBT") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "SEC-UCCBT", LastName = "Vancouver", LoginId = "secvancouver", Password = ConstValue.GetHash("secvancouver"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "SEC-UCCBT") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
                new User()
                {
                    FirstName = "UIS", LastName = "Toronto", LoginId = "uistoronto", Password = ConstValue.GetHash("uistoronto"), Permission = _context.Permissions.FirstOrDefault(x => x.Name == "User"),
                    UserSiteLocations  = new List<UserSiteLocation>()
                    {
                        new UserSiteLocation() { CreatedDate = DateTime.Now, SiteLocation = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "UIS") }
                    },
                    CreatedDate = DateTime.Now, CreatedUserId = 1
                },
            };

            _context.Users.AddRange(users);
            _context.SaveChanges();
        }

        public void AddHomestays()
        {
            var homestays = new List<Homestay>
            {

                new Homestay() { FirstName = "Agnes", LastName = "Hontanosas", Address = "57 Mcgregor Rd", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-25 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Agnes", LastName = "Hontanosas", Birthday = DateTime.Parse("05-10-1967"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Mario", LastName = "Dela Fuente", Birthday = DateTime.Parse("03-03-1963"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Marc", LastName = "Dela Fuente", Birthday = DateTime.Parse("01-22-2001"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Martin", LastName = "Dela Fuente", Birthday = DateTime.Parse("09-26-2002"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-22-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-22-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Agnes", LastName = "Santos", Address = "49 Regatta Cres", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-21 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Agnes", LastName = "Santos", Birthday = DateTime.Parse("04-22-1962"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Lorenzo", LastName = "Sanots", Birthday = DateTime.Parse("09-05-1959"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Lorraine", LastName = "Santos", Birthday = DateTime.Parse("06-02-1989"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Lyka", LastName = "Santos", Birthday = DateTime.Parse("01-28-1993"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-10-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-24-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Akime", LastName = "Bello", Address = "8 Bison Drive", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-26 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Akime", LastName = "Bello", Birthday = DateTime.Parse("04-26-1966"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Arnulfo", LastName = "Bello", Birthday = DateTime.Parse("05-26-1963"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Aiko", LastName = "Bello", Birthday = DateTime.Parse("08-29-2002"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Alexander", LastName = "Bello", Birthday = DateTime.Parse("03-26-2005"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Adam", LastName = "Bello", Birthday = DateTime.Parse("03-01-2007"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Michelle", LastName = "Bello", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-06-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Alma", LastName = "Custodio", Address = "12 Wolfe Ave", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 35, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-06-17 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Alma", LastName = "Custodio", Birthday = DateTime.Parse("06-09-1957"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Kyle", LastName = "Domingo", Birthday = DateTime.Parse("07-07-2006"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-15-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Amalia", LastName = "Lim", Address = "1015-175 Hilda Ave", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 41, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Anilyn", LastName = "Galarosa", Address = "423 Conley St", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-04-28 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Anilyn", LastName = "Galarosa", Birthday = DateTime.Parse("05-10-1970"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Guzman", LastName = "Galarosa", Birthday = DateTime.Parse("08-26-1973"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Maverick", LastName = "Galarosa", Birthday = DateTime.Parse("09-11-2005"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Eileen", LastName = "Galarosa", Birthday = DateTime.Parse("09-11-2005"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Florentino", LastName = "Fernandez", Birthday = DateTime.Parse("10-22-1972"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Edralyn", LastName = "Arocena", Birthday = DateTime.Parse("12-14-1971"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-13-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Arlene", LastName = "Aleluya", Address = "44 Levitt Court", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-14 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Arlene", LastName = "Aleluya", Birthday = DateTime.Parse("10-30-1971"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Tueday", LastName = "Aleluya", Birthday = DateTime.Parse("09-16-1975"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Lyndie", LastName = "Aleluya", Birthday = DateTime.Parse("03-02-2002"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Stephanie", LastName = "Aleluya", Birthday = DateTime.Parse("07-25-2004"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Darryl", LastName = "Aleluya", Birthday = DateTime.Parse("04-27-2007"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Kevin", LastName = "Aleluya", Birthday = DateTime.Parse("10-19-2010"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-11-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-11-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Arthur", LastName = "John", Address = "17 Lillington Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-01-24 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Arthur", LastName = "John", Birthday = DateTime.Parse("07-25-1953"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Heather", LastName = "John", Birthday = DateTime.Parse("01-21-1961"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Rachel", LastName = "John", Birthday = DateTime.Parse("11-13-1984"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jasmine", LastName = "Lehaney", Birthday = DateTime.Parse("12-03-2004"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Quintin", LastName = "Lehaney", Birthday = DateTime.Parse("10-06-2008"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jada", LastName = "Power", Birthday = DateTime.Parse("02-21-2011"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-14-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Bingle", LastName = "Laspona", Address = "76 Pinebrook Ave", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-13 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Bingle", LastName = "Laspona", Birthday = DateTime.Parse("05-06-1975"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Crispin", LastName = "Laspona", Birthday = DateTime.Parse("03-1973"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Emie", LastName = "Laspona", Birthday = DateTime.Parse("12-1972"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Iryz", LastName = "Laspona", Birthday = DateTime.Parse("10-2006"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Kirbin", LastName = "Laspona", Birthday = DateTime.Parse("09-2009"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-30-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Carmelita", LastName = "Aboc", Address = "37 Levitt Court", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-14 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Carmelita", LastName = "Aboc", Birthday = DateTime.Parse("08-19-1945"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("02-27-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Carmencita", LastName = "Tolentino", Address = "", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Caroline", LastName = "Fonacier", Address = "95 Green Bush", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-06-16 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Caroline", LastName = "Fonacier", Birthday = DateTime.Parse("03-09-1972"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Joselito", LastName = "Fonacier", Birthday = DateTime.Parse("12-21-1968"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Cleofe", LastName = "Fonacier", Birthday = DateTime.Parse("07-22-1994"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jay", LastName = "Fonacier", Birthday = DateTime.Parse("11-04-1995"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-24-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Grace", LastName = "Januyan", Address = "5-28 Wasdale Cres", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Grace", LastName = "Januyan", Birthday = DateTime.Parse("01-07-1974"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-04-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Guillermo", LastName = "Nabong", Address = "26 Leafy Woodway", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-03-25 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Guillermo", LastName = "Nabong", Birthday = DateTime.Parse("11-21-1964"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Mary", LastName = "Nabong", Birthday = DateTime.Parse("09-19-1964"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Alexa", LastName = "Nabong", Birthday = DateTime.Parse("02-09-2009"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Vanessa", LastName = "Nabong", Birthday = DateTime.Parse("01-18-2011"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-19-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-23-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Gwen", LastName = "Edamura", Address = "", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 41, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Hermelinda", LastName = "Ochotorena", Address = "171 Livingstone Ave", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 36, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-03-15 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Hermelinda", LastName = "Ochotorena", Birthday = DateTime.Parse("12-26-1957"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ivan", LastName = "Ochotorena", Birthday = DateTime.Parse("10-24-1980"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Irene", LastName = "Corilla", Birthday = DateTime.Parse("05-14-1976"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("02-02-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-11-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-11-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Jerry", LastName = "Rodulfa", Address = "18 Janet Blvd", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 38, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Aurora", LastName = "Rodulfa", Birthday = DateTime.Parse("07-18-1969"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jerry", LastName = "Rodulfa", Birthday = DateTime.Parse("08-03-1972"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Aurora", LastName = "Immaculat Rodulfa", Birthday = DateTime.Parse("01-06-1997"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("10-11-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("10-11-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Jill", LastName = "Arates", Address = "776 Danforth Rd", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 37, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-02-06 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Jill", LastName = "Artates", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Helena", LastName = "Artates", Birthday = DateTime.Parse("08-25-1998"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("09-13-2011"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Jocelyn", LastName = "De Castro", Address = "101 Dundalk Dr", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 41, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-12 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Jocelyn", LastName = "De Castro", Birthday = DateTime.Parse("07-10-1967"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Hans", LastName = "De Castro", Birthday = DateTime.Parse("07-11-1966"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("05-21-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("05-21-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Joenar", LastName = "Tubera", Address = "208-5 Rannock St", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Joenar", LastName = "Renon", Birthday = DateTime.Parse("05-18-1968"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-19-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Julieta", LastName = "Gonzaga", Address = "1604-5 Shady Golfway", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 41, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Lilibeth", LastName = "Caacbay", Address = "73 Croteau Crescent", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 42, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Lisa", LastName = "Conover", Address = "375 Lumsden Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 38, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-01-23 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Lisa", LastName = "Conover", Birthday = DateTime.Parse("09-21-1958"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Hannah", LastName = "Conover", Birthday = DateTime.Parse("12-14-1994"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Lolita", LastName = "Miclat", Address = "20 Greenwich Sq", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 38, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Lorena", LastName = "Manganaan", Address = "73 Wilmont Dr", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 37, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Lorena", LastName = "Manganaan", Birthday = DateTime.Parse("11-06-1978"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-24-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Lorina", LastName = "Hiponia", Address = "28 Hinda Lane", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 44, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Margielyn", LastName = "Provido", Address = "3322 Bathurst Street", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 46, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Maribel", LastName = "Hernandez", Address = "16 Autumn Ave", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 37, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2014-08-11 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Maribel", LastName = "Hernandez", Birthday = DateTime.Parse("08-30-1978"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Artred", LastName = "Hernandez", Birthday = DateTime.Parse("11-30-1978"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Antonette", LastName = "Mendoza", Birthday = DateTime.Parse("06-20-1976"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "David", LastName = "Hernandez", Birthday = DateTime.Parse("04-05-2003"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-30-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Marieta", LastName = "Lopez", Address = "308-10 Edge Cliffe Golfway", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2013-12-27 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Marieta", LastName = "Lopez", Birthday = DateTime.Parse("06-05-1963"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Sharon", LastName = "Duabe", Birthday = DateTime.Parse("07-09-1981"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-04-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-30-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Marites", LastName = "Celestial", Address = "37 Jinnah Crt", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 41, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-12-20 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Marites", LastName = "Celestial", Birthday = DateTime.Parse("11-28-1966"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ralph", LastName = "Celestial", Birthday = DateTime.Parse("07-17-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Mika", LastName = "Celestial", Birthday = DateTime.Parse("10-15-1999"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("09-17-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-07-2011"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Mary", LastName = "Jane Bantolinao", Address = "125 Leeward Glenway", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Mary", LastName = "Jane Benologa", Address = "1227 Pharmacy Ave", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-01-02 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Mary", LastName = "Jane Benologa", Birthday = DateTime.Parse("08-19-1978"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Elmer", LastName = "Benologa", Birthday = DateTime.Parse("12-03-1976"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Joriz", LastName = "Benologa", Birthday = DateTime.Parse("09-27-2008"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jake", LastName = "Benologa", Birthday = DateTime.Parse("01-03-2013"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("10-08-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-29-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Melissa", LastName = "David", Address = "6 Springside Way", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Melissa", LastName = "David", Birthday = DateTime.Parse("10-26-1963"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Mario", LastName = "David", Birthday = DateTime.Parse("03-10-1964"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-18-2008"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-10-2008"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Michael", LastName = "Claxton", Address = "113 Fred Young Dr", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 41, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-01-20 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Michael", LastName = "Claxton", Birthday = DateTime.Parse("11-26-1965"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Sharon", LastName = "Claxton", Birthday = DateTime.Parse("09-10-1968"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Stephan", LastName = "Claxton", Birthday = DateTime.Parse("01-03-2000"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("09-20-2007"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Michelle", LastName = "Clemente", Address = "126 Dollery Court", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-09-06 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Michelle", LastName = "Clemente", Birthday = DateTime.Parse("06-05-1973"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Erwin", LastName = "Clemente", Birthday = DateTime.Parse("10-31-1969"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jared", LastName = "Clemente", Birthday = DateTime.Parse("02-14-2001"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Clemerson", LastName = "Clemente", Birthday = DateTime.Parse("07-16-2004"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-01-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-01-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Michelle", LastName = "Pasklay", Address = "74 Elise Terrace", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Mildred", LastName = "Lactaotao", Address = "", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Miraflor", LastName = "Gragasin", Address = "15 Vradenberg Dr", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 36, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-26 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Miraflor", LastName = "Gragasin", Birthday = DateTime.Parse("01-02-1964"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Draco", LastName = "Gragasin", Birthday = DateTime.Parse("06-16-1960"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "David", LastName = "Andrew Gragasin", Birthday = DateTime.Parse("04-26-1996"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Maida", LastName = "Gayle Gragasin", Birthday = DateTime.Parse("10-03-1989"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Nestor", LastName = "Arcangel", Address = "97 Robert Hicks Dr", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 41, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-11 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Nestor", LastName = "Arcangel", Birthday = DateTime.Parse("01-23-1953"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Segundina", LastName = "Arcangel", Birthday = DateTime.Parse("01-01-1955"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Mark", LastName = "Arcangel", Birthday = DateTime.Parse("01-28-1989"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-10-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-10-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-29-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Pacita", LastName = "Valdez", Address = "643-A Caledonia Rd", Language = "ESL", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 36, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-03-16 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Pacita", LastName = "Valdez", Birthday = DateTime.Parse("07-26-1961"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Transito", LastName = "Valdez", Birthday = DateTime.Parse("08-13-1957"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Bradley", LastName = "Valdez", Birthday = DateTime.Parse("03-04-1997"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-02-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-02-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Randy", LastName = "Salinas", Address = "3 Carthage Ave", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 38, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-01-22 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Randy", LastName = "Salinas", Birthday = DateTime.Parse("12-08-1971"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Cristy", LastName = "Salinas", Birthday = DateTime.Parse("11-21-1971"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Juby", LastName = "", Birthday = DateTime.Parse("07-03-1969"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "John", LastName = "Salinas", Birthday = DateTime.Parse("04-23-2006"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-04-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-06-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Renata", LastName = "Kowalska", Address = "597 Scarlett Rd", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 41, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Renata", LastName = "Kowlaska", Birthday = DateTime.Parse("03-20-1967"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Tadedsz", LastName = "", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Krysmna", LastName = "", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "", LastName = "Victoria", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("10-16-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Rosalie", LastName = "Lopez", Address = "16 Wetherby Dr", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Rosalie", LastName = "Miclat", Address = "78 Saddle Ridge Dr", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 41, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Rowena", LastName = "Cacayurin", Address = "95 Gweenwin Village Rd", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 37, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Rowena", LastName = "Cacayurin", Birthday = DateTime.Parse("10-15-1973"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Regina", LastName = "Concepcion", Birthday = DateTime.Parse("08-25-1968"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Owen", LastName = "Cacayurin", Birthday = DateTime.Parse("07-16-2003"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-20-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Ruby", LastName = "Bondoc", Address = "", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Ruby", LastName = "Vidal", Address = "19 Plum Tree Way", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Ruby", LastName = "Vidal", Birthday = DateTime.Parse("10-11-1974"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ronald", LastName = "Vidal", Birthday = DateTime.Parse("10-07-1973"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Rioben", LastName = "Vidal", Birthday = DateTime.Parse("07-23-1998"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Rhonaby", LastName = "Vidal", Birthday = DateTime.Parse("02-20-2001"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ray", LastName = "Neil Vidal", Birthday = DateTime.Parse("10-21-2002"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-09-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-12-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Sandra", LastName = "Inglis", Address = "", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 37, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Sandra", LastName = "Reyes-Morgan", Address = "101 Jarwick Dr", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 41, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Sandra", LastName = "Reyes-Morgan", Birthday = DateTime.Parse("06-24-1958"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Zachary", LastName = "Reyes-Morgan", Birthday = DateTime.Parse("03-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Chelsea", LastName = "Reyes-Morgan", Birthday = DateTime.Parse("11-1992"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Alastair", LastName = "Reyes-Morgan", Birthday = DateTime.Parse("04-1997"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-11-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Thelma", LastName = "Black", Address = "41 Brian Ave", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-12-11 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Thelma", LastName = "Black", Birthday = DateTime.Parse("11-06-1958"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Paul", LastName = "Black", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Seth", LastName = "Black", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-03-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Vicente", LastName = "Dammog", Address = "33 Kenton Drive", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-11-29 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Vicente", LastName = "Dammog", Birthday = DateTime.Parse("09-07-1971"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Mayvelle", LastName = "Dammog", Birthday = DateTime.Parse("08-08-1970"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Vyncee", LastName = "Dammog", Birthday = DateTime.Parse("05-04-2001"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Maycee", LastName = "Dammog", Birthday = DateTime.Parse("04-15-2004"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Haycee", LastName = "Dammog", Birthday = DateTime.Parse("01-11-2008"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-24-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-24-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Aileen", LastName = "de Jesus", Address = "29 Canadine Rd", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 23/25, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-11-08 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Aileen", LastName = "de Jesus", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Rolando", LastName = "de Jesus", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jemmina", LastName = "Luz", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Renz", LastName = "de Jesus", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Bernadeth", LastName = "de Jesus", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Alvin", LastName = "de la Paz", Address = "12-7 Oakburn", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Alvin", LastName = "de la Paz", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Dominga", LastName = "Salvador", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Tara", LastName = "de la Paz", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Amy", LastName = "Trim", Address = "119 Dollery Court", Language = "English", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-03-18 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Amy", LastName = "Trim", Birthday = DateTime.Parse("06-24-1979"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-27-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Andrew", LastName = "Edsen", Address = "22 Station Rd", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-13 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Andrew", LastName = "Esden", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Marianna", LastName = "Esden", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Angela", LastName = "Romano", Address = "55 Heale Ave", Language = "English", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-03-17 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Angela", LastName = "Romano", Birthday = DateTime.Parse("07-01-1956"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Roberto", LastName = "Romano", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-24-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Angela", LastName = "Stasolla", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Angela", LastName = "Stasolla", Birthday = DateTime.Parse("11-08-1965"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Tony", LastName = "Stasolla", Birthday = DateTime.Parse("12-19-1963"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Fabrizo", LastName = "Luca Stasolla", Birthday = DateTime.Parse("02-18-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-05-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-05-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("02-27-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Anna", LastName = "Attardo", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-08-31 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Anna", LastName = "Attardo", Birthday = DateTime.Parse("03-04-1991"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("05-30-2002"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Anna-Maria", LastName = "Rainaldi", Address = "216 Linden Ave", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-04-15 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Maria", LastName = "Rainaldi", Birthday = DateTime.Parse("12-04-1986"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Anna-Maria", LastName = "Rainaldi", Birthday = DateTime.Parse("06-25-1950"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-26-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-26-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Beena", LastName = "Rajendra", Address = "331 Strathmore Blvd", Language = "English", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-18 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Beena", LastName = "Rajendra", Birthday = DateTime.Parse("11-25-1943"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("02-21-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Carlos", LastName = "Yarcia", Address = "124 South Edgely Ave", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 47, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-11-17 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Carolos", LastName = "Yarcia", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Nellie", LastName = "Yarcia", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Hannah", LastName = "Yarcia", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Hugh", LastName = "Yarcia", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Catherine", LastName = "Scianna", Address = "55 Peterborough Ave", Language = "ESL", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 28, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-11-10 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Celia", LastName = "Agravantes", Address = "1 Frater Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-29 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Celia", LastName = "Agravantes", Birthday = DateTime.Parse("08-10-1946"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-22-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Cesar", LastName = "Luna", Address = "34 Maurice Coulter Mews", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-05-19 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Cesar", LastName = "Luna", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Norma", LastName = "Luna", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jose", LastName = "Luna", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Christine", LastName = "Miclat", Address = "182 Coleman Ave", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 35, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-10-03 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Christine", LastName = "Miclat", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Myra", LastName = "Aguinaldo", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Claudia", LastName = "Cardinez", Address = "11 Burtonwood Cres", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Claudia", LastName = "Cardinez", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Cleveland", LastName = "Cardinez", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Candice", LastName = "Cardinex", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Connie", LastName = "Tizon", Address = "801-85 Wellesly St", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 48, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-11-25 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Connie", LastName = "Tizon", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Carazon", LastName = "Tizon", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Bernie", LastName = "Tizon", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("10-09-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Cora", LastName = "Galipo", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-11-19 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-19-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Daphne", LastName = "Tucker", Address = "75 Woody Vine Way", Language = "English", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-11-10 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Daphne", LastName = "Tucker", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "David", LastName = "Guvercin", Address = "9 Acores Ave", Language = "English", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-12 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "David", LastName = "Guvercin", Birthday = DateTime.Parse("01-15-1979"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Maila", LastName = "Abenoja", Birthday = DateTime.Parse("08-31-1974"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Kenan", LastName = "Guvercin", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-13-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-27-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Deborah", LastName = "Moir", Address = "5 Capalina Dr", Language = "English", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 37, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-11-30 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Deborah", LastName = "Moir", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Mark", LastName = "O'Hara", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Dina", LastName = "Soultanis", Address = "463 Cosburn Ave", Language = "English", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-04 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Constantina", LastName = "Soultanis", Birthday = DateTime.Parse("01-05-1958"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Elies", LastName = "Soultanis", Birthday = DateTime.Parse("06-24-1950"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-30-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-19-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Donna", LastName = "Saccutelli", Address = "25 Southbourne Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 45, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-11-21 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Donna", LastName = "Saccutelli", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ron", LastName = "Saccutelli", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "David", LastName = "Saccutelli", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "James", LastName = "Saccutelli", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Edgar", LastName = "Garingalao", Address = "9 Autumn Ave", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-08-10 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Edgar", LastName = "Garingalao", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Perla", LastName = "Garingalao", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Elinore", LastName = "Ambray", Address = "506-2500 Keele St.", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-04 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Elinore", LastName = "Ambray", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Elizabeth", LastName = "Burell", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Elizabeth", LastName = "Burrell", Birthday = DateTime.Parse("02-17-1943"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-07-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Elizabeth", LastName = "Cruz", Address = "157 Santamonica Blvd", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-12 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Elizabeth", LastName = "Cruz", Birthday = DateTime.Parse("02-13-1959"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jeremy", LastName = "Cruz", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-16-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Elizabeth", LastName = "Salmon", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "John", LastName = "Salmon", Birthday = DateTime.Parse("03-16-1945"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Elizabeth", LastName = "Salmon", Birthday = DateTime.Parse("03-01-1947"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("10-28-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("10-28-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Emily", LastName = "Santos", Address = "15 Bloem Ave", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-07-13 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Emily", LastName = "Santos", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jessie", LastName = "Santos", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jeremy", LastName = "Santos", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Eva", LastName = "Cabrera", Address = "565 Wilson Ave", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-11-05 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Evangeline", LastName = "Cabrera", Birthday = DateTime.Parse("01-03-1964"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jamila", LastName = "Zoubi", Birthday = DateTime.Parse("07-09-1996"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-20-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-20-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Evangeline", LastName = "Iquin", Address = "12 Bowsfield", Language = "English", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-08-17 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Evangeline", LastName = "Iquin", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Honoria", LastName = "Iquin", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Faresah", LastName = "Ali", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Faresah", LastName = "Ali", Birthday = DateTime.Parse("01-11-1973"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-30-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Felicia", LastName = "Spiegelman", Address = "414 Ellerslie Ave", Language = "English", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Felicia", LastName = "Spiegelman", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Samantha", LastName = "Spiegelman", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Spencer", LastName = "Speigelman", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Felicidad", LastName = "Karls", Address = "46 Stansbury Cres", Language = "", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-03-30 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Felicidad", LastName = "Karls", Birthday = DateTime.Parse("11-23-1962"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Pio", LastName = "Pechida", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jordan", LastName = "Karls", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-23-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Francesca", LastName = "Caruso", Address = "55 Commonwealth Ave", Language = "English", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-08-05 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Francesca", LastName = "Caruso", Birthday = DateTime.Parse("12-02-1954"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Francesco", LastName = "Caruso", Birthday = DateTime.Parse("05-20-1950"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("05-01-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("05-01-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Gordana", LastName = "Cafarelli", Address = "93 Highland Hill", Language = "English", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-11-29 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Gordana", LastName = "Cafarelli", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Mario", LastName = "Cafarelli", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Natalie", LastName = "Cafarelli", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Heidi", LastName = "Walker", Address = "1615 Woodbine Heights Blvd", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-23 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Heiderose", LastName = "Walker", Birthday = DateTime.Parse("07-15-1965"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("02-28-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Ida", LastName = "Sanchez", Address = "", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 29, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Imelda", LastName = "Yntig", Address = "699 Danforth Rd", Language = "English", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 21, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-11-14 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Irene", LastName = "Kousis", Address = "202-19 Rosemount Dr", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-02 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Irene", LastName = "Kousis", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Bob", LastName = "Kousis", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Jane", LastName = "Gregory", Address = "89 Pickering St", Language = "English", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-13 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Jane", LastName = "Gregory", Birthday = DateTime.Parse("11-22-1945"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Emma", LastName = "Gregory", Birthday = DateTime.Parse("10-18-1991"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-01-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-01-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Jane", LastName = "Salangsang", Address = "1254 Danforth Rd", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-08 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "John", LastName = "Salangsang", Birthday = DateTime.Parse("08-06-1988"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Pineda", LastName = "Salangsang", Birthday = DateTime.Parse("08-18-1961"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jane", LastName = "Salangsang", Birthday = DateTime.Parse("06-12-1961"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-02-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-02-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-02-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Jasmin", LastName = "Bulchand", Address = "106 Silvio Ave", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-10-20 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Jasmin", LastName = "Bulchand", Birthday = DateTime.Parse("05-17-1944"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-16-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Jennifer", LastName = "Ranjo", Address = "61 Ascolda Blvd", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-05-15 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Jenny", LastName = "Ranjo", Birthday = DateTime.Parse("03-24-1970"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ronnie", LastName = "Co", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ryan", LastName = "Co", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Michelle", LastName = "Co", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Jocelyn", LastName = "Ramos", Address = "8 Bexhill Court", Language = "English", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-09 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Jocelyn", LastName = "Ramos", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Nenita", LastName = "Reyes", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Dyohana", LastName = "Ramos", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Judith", LastName = "Cameron", Address = "13-2425 Finch Ave W", Language = "", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Judith", LastName = "Cameron", Birthday = DateTime.Parse("10-18-1965"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-17-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Kay", LastName = "Bascombe", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-08-27 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Kelly", LastName = "Esteban", Address = "512 Bellamy Rd N", Language = "", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Kelly", LastName = "Esteban", Birthday = DateTime.Parse("04-23-1965"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Eddie", LastName = "Esteban", Birthday = DateTime.Parse("04-08-1959"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("10-09-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("10-09-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Zlate", LastName = "Korapiz", Address = "1393 Victoria Park Ave", Language = "English", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-23 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Zlate", LastName = "Korapiz", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Vlademir", LastName = "Korapiz", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Mario", LastName = "Korapiz", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Milosh", LastName = "Korapiz", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Lal", LastName = "de Zoysa", Address = "65 Kimberdale Cres", Language = "", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-21 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Badra", LastName = "De Zoysa", Birthday = DateTime.Parse("10-24-1954"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Padmalal", LastName = "De Zoysa", Birthday = DateTime.Parse("09-20-1950"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Avanthi", LastName = "De Zoysa", Birthday = DateTime.Parse("01-23-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Eranga", LastName = "De Zoysa", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-28-2009"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-19-2008"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("02-25-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Laurel", LastName = "Stroz", Address = "126 Meighen Ave", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-08-27 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Ken", LastName = "Beebakhee", Birthday = DateTime.Parse("01-11-1971"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Laurel", LastName = "Stroz", Birthday = DateTime.Parse("07-17-1977"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-03-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-03-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Leo", LastName = "Lupo", Address = "70 South Bonnington Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-06-07 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Zaria", LastName = "Lupo", Birthday = DateTime.Parse("06-18-1968"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Leo", LastName = "Lupo", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Luca", LastName = "Lupo", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Marco", LastName = "Lupo", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Lilibeth", LastName = "Caacbay", Address = "73 Croteau Cres", Language = "ESL", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-15 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Lilibeth", LastName = "Caacbay", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Manuel", LastName = "Caacbay", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Marilyn", LastName = "Caacbay", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Crisah", LastName = "Caacbay", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Lina", LastName = "Lupo", Address = "159 South Woodrow Ave", Language = "ESL", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-03-17 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Michelle", LastName = "Lupo", Birthday = DateTime.Parse("03-22-1941"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-19-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Linda", LastName = "Ohrstrom", Address = "13 Snapdragon Dr", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-12 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Linda", LastName = "Ohrstrom", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Lolita", LastName = "Miclat", Address = "20 Greenwhich Square", Language = "ESL", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-27 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Lolita", LastName = "Miclat", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ross", LastName = "Miclat", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Rochelle", LastName = "Miclat", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Carter", LastName = "Miclat", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Lorraine", LastName = "Bertrand", Address = "272 Chine Dr", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-13 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Lorraine", LastName = "Bertrand", Birthday = DateTime.Parse("02-16-1953"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-19-2005"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Lourdes", LastName = "Lavie", Address = "210A Barton Ave", Language = "ESL", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-03-26 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Lourdes", LastName = "Lavie", Birthday = DateTime.Parse("02-11-1965"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-25-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Lucia", LastName = "Moncada", Address = "32 Shaunavon Heights Cres", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Lucy", LastName = "Moncada", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Enza", LastName = "Moncada", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Enza", LastName = "Moncada", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Cory", LastName = "Moncada", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Mark", LastName = "Cooper", Address = "37 Rodda Blvd", Language = "English", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Maroulla", LastName = "Andreou", Address = "74 Elvaston Drive", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-04 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Maroulla", LastName = "Andreou", Birthday = DateTime.Parse("01-10-1953"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "John", LastName = "Pouris", Birthday = DateTime.Parse("07-15-1951"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "George", LastName = "Pouris", Birthday = DateTime.Parse("11-06-1991"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-19-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-20-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-20-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Mike", LastName = "Konnaris", Address = "6 Arbutus Cres", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-08 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Mike", LastName = "Konnaris", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Natakie", LastName = "Reid", Address = "610 Vaughan Rd", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-11-10 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Natakie", LastName = "Red-Calliste", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "John", LastName = "Calliste", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Genesis", LastName = "Calliste", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Natalia", LastName = "Jimenez", Address = "20 Sparrow Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-05-23 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Natalia", LastName = "Jimenez", Birthday = DateTime.Parse("01-08-1980"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Joshua", LastName = "Jimenez", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Nathan", LastName = "Jimenez", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-24-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Natasha", LastName = "Borg", Address = "196 Linsmore Cres", Language = "English", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-03-20 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Natasha", LastName = "Borg", Birthday = DateTime.Parse("09-03-1973"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Andrew", LastName = "Kichuk", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Monika", LastName = "Kichuk", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-28-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Nelson", LastName = "Galang", Address = "8 Greenwich Ave", Language = "ESL", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-08 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Nelson", LastName = "Galang", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Barbara", LastName = "Cuoal", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Ofelia", LastName = "Agaran", Address = "65 Dalbeattie Ave", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-06-08 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Ofelia", LastName = "Agaran", Birthday = DateTime.Parse("05-19-1957"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Kevin", LastName = "Agaran", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ryan", LastName = "Agaran", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Patti", LastName = "Cookman", Address = "60 Dorset Rd", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 36, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-11-09 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Patti", LastName = "Cookman", Birthday = DateTime.Parse("05-24-1959"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Justin", LastName = "Cookman", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-01-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Raquel", LastName = "Huelar", Address = "65 Yore Rd", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-07 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Raquel", LastName = "Huelar", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Kevin", LastName = "Huelar", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Roel", LastName = "Huelar", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Sean", LastName = "Huelar", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Ron", LastName = "Andrews", Address = "169 Lord Seaton Rd", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 44, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-11-21 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Ron", LastName = "Andrews", Birthday = DateTime.Parse("05-22-1939"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Sheila", LastName = "Andrews", Birthday = DateTime.Parse("11-17-1947"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("09-27-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("09-27-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Rosa", LastName = "Tucci", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Rosa", LastName = "Tucci", Birthday = DateTime.Parse("09-28-1968"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Giovanni", LastName = "Tucci", Birthday = DateTime.Parse("09-06-2964"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("09-02-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("09-03-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Rosalie", LastName = "Miclat", Address = "31 Greenwich Square", Language = "ESL", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-08 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Rosalie", LastName = "Miclat", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Rolando", LastName = "Miclat", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Robert", LastName = "Miclat", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Ruel", LastName = "Escopete", Address = "310-155 Leaward Glenway", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-26 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Marie", LastName = "Escopete", Birthday = DateTime.Parse("01-04-1993"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ruel", LastName = "Escopete", Birthday = DateTime.Parse("03-06-1965"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Doris", LastName = "Escopete", Birthday = DateTime.Parse("09-20-1962"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "John", LastName = "Micheal Escopete", Birthday = DateTime.Parse("08-25-1989"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-10-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-09-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-10-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-10-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Sabina", LastName = "Quintente", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Sabrina", LastName = "Wilson", Address = "24 Bellamy Rd", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 40, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Sabrina", LastName = "Wilson", Birthday = DateTime.Parse("02-24-1956"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Paul", LastName = "Wilson", Birthday = DateTime.Parse("09-19-1969"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-04-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-05-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Sahar", LastName = "Mahdi", Address = "77 Greenland Rd", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-06 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Sahar", LastName = "Mahdi", Birthday = DateTime.Parse("04-13-1964"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Sowad", LastName = "Mahdi", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Isra", LastName = "Mahdi", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Sarah", LastName = "Mahdi", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-16-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Serena", LastName = "Greco", Address = "707-26 Engelhart Cres", Language = "ESL", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-08-31 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Serena", LastName = "Greco", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Andrea", LastName = "Greco", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Stathie", LastName = "Saroglou", Address = "12 Elmont Dr", Language = "English", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Stathie", LastName = "Saroglou", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Helen", LastName = "Saroglou", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Markos", LastName = "Saroglou", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Abby", LastName = "Saroglou", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "John", LastName = "Saroglou (4", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Susanna", LastName = "Voros", Address = "615 Finch Ave W", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-01 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Susana", LastName = "Voros", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Steve", LastName = "Voros", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Teresa", LastName = "Alvarez", Address = "48 Beechborough", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-26 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Teresa", LastName = "Alvarez", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Sabina", LastName = "Alvarez", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Maria", LastName = "Alvarez", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Markella", LastName = "Alvarez", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Vidyo", LastName = "Persaud", Address = "20 Dunlop Ave", Language = "English", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-10-20 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Nadia", LastName = "Persaud", Birthday = DateTime.Parse("05-19-1989"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Vidyo", LastName = "Persaud", Birthday = DateTime.Parse("11-04-1956"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ram", LastName = "Oersaud", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-20-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-20-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Vivian", LastName = "Talosig", Address = "23 Birdstone Cres", Language = "", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Vivian", LastName = "Talosig", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Erwin", LastName = "Talosig", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Reeze", LastName = "Talosig", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Gerard", LastName = "Talosig", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Shan", LastName = "Talosig", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Wilhelmina", LastName = "Fischer", Address = "71 Glenshephard Dr", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 40, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-11-14 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Wilhelmina", LastName = "Fischer", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Yusleydys", LastName = "de los Rios", Address = "406 Lumsden Ave", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-12 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Yusleydys", LastName = "de los Rios", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Melanis", LastName = "de la Resa", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Brian", LastName = "de los Rios", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Alma", LastName = "Ulob", Address = "3891-A-Bathurst St", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 40, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-06-14 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Alma", LastName = "Ulob", Birthday = DateTime.Parse("10-14-1973"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Shanen", LastName = "Ulob", Birthday = DateTime.Parse("03-30-1997"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Aron", LastName = "Ulob", Birthday = DateTime.Parse("12-15-2006"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Marilyn", LastName = "", Birthday = DateTime.Parse("08-03-1965"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Amy", LastName = "Trim", Address = "119 Dollery Crt", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-03-15 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Amy", LastName = "Trim", Birthday = DateTime.Parse("06-24-1979"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("2014-03-24 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Aurora", LastName = "Somera", Address = "643B Caledonia Rd", Language = "English", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 33, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-03-10 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Aurora", LastName = "Somera", Birthday = DateTime.Parse("02-04-1962"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Roberto", LastName = "Somera", Birthday = DateTime.Parse("08-27-1956"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-19-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-19-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Belinda", LastName = "Earle", Address = "28 Leila Jackson Terrace", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-03-27 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Belinda", LastName = "St Ville", Birthday = DateTime.Parse("12-13-1983"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-23-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Betty", LastName = "Vana", Address = "501-55 Erskine Ave", Language = "ESL", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Betty", LastName = "Vana", Birthday = DateTime.Parse("05-29-1951"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Mario", LastName = "Masucci", Birthday = DateTime.Parse("05-29-1945"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Martina", LastName = "Fisherova", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-11-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Christine", LastName = "Miclat", Address = "2 Greenwich Square", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-21 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Danilo", LastName = "Miclat", Birthday = DateTime.Parse("03-28-1965"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Christine", LastName = "Miclat", Birthday = DateTime.Parse("09-21-1976"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-25-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-25-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Christopher", LastName = "Coroco", Address = "", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 35, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-07-26 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                },

                new Homestay() { FirstName = "Dominic", LastName = "Nater", Address = "Unit 4-2 White Abbey Park", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 37, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-06-13 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Dominic", LastName = "Nater", Birthday = DateTime.Parse("07-21-1980"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jessica", LastName = "Kuo", Birthday = DateTime.Parse("11-17-1977"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("02-19-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Gloria", LastName = "Manrique Santos", Address = "59 Ferrand Drive", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 35, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-06-29 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Rachel", LastName = "Santos", Birthday = DateTime.Parse("07-12-1994"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Gloria", LastName = "Manrique Santos", Birthday = DateTime.Parse("11-28-1954"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-30-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("09-15-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Helen", LastName = "Aphantitis", Address = "14 Mango Drive", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 36, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-04-14 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Jermal", LastName = "Stephens", Birthday = DateTime.Parse("10-08-1974"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Helen", LastName = "Aphantitis", Birthday = DateTime.Parse("11-17-1972"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Sierra", LastName = "Stephens", Birthday = DateTime.Parse("10-19-2996"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-11-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-10-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Judith", LastName = "Cameron", Address = "2425 Finch Ave W#13", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 37, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Judith", LastName = "Cameron", Birthday = DateTime.Parse("10-18-1965"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Judith", LastName = "Rimando", Address = "713 Vaughn Rd.", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 37, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-06-02 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Judith", LastName = "Rimando", Birthday = DateTime.Parse("06-13-1966"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Edmon", LastName = "Rimando", Birthday = DateTime.Parse("03-25-1970"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Admina", LastName = "Rimando", Birthday = DateTime.Parse("08-09-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-01-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Kadriye", LastName = "Balta", Address = "67 Wicklow Dr", Language = "English", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 34, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-02-26 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Kadriye", LastName = "Balta", Birthday = DateTime.Parse("10-29-1959"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Mehmet", LastName = "Balta", Birthday = DateTime.Parse("01-10-1945"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-18-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-18-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Lolita", LastName = "Bandong", Address = "45 Southampton Drive", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-06-09 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Dimitrios", LastName = "Leimonis", Birthday = DateTime.Parse("05-08-1944"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Lolita", LastName = "Bandong", Birthday = DateTime.Parse("12-15-1958"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-21-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-06-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Maria", LastName = "Calabrese", Address = "2 Glendinning Ave", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 34, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-06-15 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Maria", LastName = "Calabrese", Birthday = DateTime.Parse("04-10-1960"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("2013-12-10 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Maria", LastName = "Luz Casareno", Address = "438 Conley St", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 35, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-09-20 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Maria", LastName = "Luz Casareno", Birthday = DateTime.Parse("02-23-1960"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ellya", LastName = "Casareno", Birthday = DateTime.Parse("11-01-1965"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Richard", LastName = "Casareno", Birthday = DateTime.Parse("10-08-1988"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Martites", LastName = "Balura", Address = "96 Eileen Ave", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 34, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-08-27 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Marites", LastName = "Balura", Birthday = DateTime.Parse("03-11-1974"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Dexter", LastName = "Teh", Birthday = DateTime.Parse("12-12-1970"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Danya", LastName = "Teh", Birthday = DateTime.Parse("02-10-1970"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("2013-06-06 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Mary", LastName = "Ann Loresca", Address = "45 John Cabot Way", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 37, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-08-12 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Mary", LastName = "Ann Loresca", Birthday = DateTime.Parse("09-12-1982"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-16-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Nelson", LastName = "Galang", Address = "8 Greenwhich Square", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 37, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-04-22 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Nelson", LastName = "Galang", Birthday = DateTime.Parse("11-18-1970"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Barbara", LastName = "Cudal", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-29-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Regina", LastName = "Flores", Address = "19 Damask Ave", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 32, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-09-22 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Ralph", LastName = "Nacpil", Birthday = DateTime.Parse("03-31-1987"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Regina", LastName = "Flores", Birthday = DateTime.Parse("09-22-1987"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-04-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-04-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Abraham", LastName = "Matabang", Address = "15 Guildwood Parkway", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-12-08 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Jovita", LastName = "Matabang", Birthday = DateTime.Parse("10-03-1957"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Abraham", LastName = "Matabang", Birthday = DateTime.Parse("08-12-1961"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("02-24-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("02-24-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Adelpha", LastName = "Delima", Address = "5 Robert Hicks Dr", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 25, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-28 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Adelpha", LastName = "Delima", Birthday = DateTime.Parse("05-27-1951"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Alfredo", LastName = "Delima", Birthday = DateTime.Parse("05-15-1946"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Nicole", LastName = "Delima", Birthday = DateTime.Parse("05-11-1994"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Brian", LastName = "Delima", Birthday = DateTime.Parse("12-24-1988"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-30-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-30-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Andrea", LastName = "Michelle Ali", Address = "80 Cassandra", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 25, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-22 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Andrea", LastName = "Michelle Ali", Birthday = DateTime.Parse("02-05-1975"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Anita", LastName = "Soong", Address = "3 Greystone Walk Dr", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 44, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-12-01 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Anita", LastName = "Soong Ngui-Yen", Birthday = DateTime.Parse("02-02-1978"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Bruce", LastName = "Ngui-Yen", Birthday = DateTime.Parse("06-05-1978"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-29-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-30-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Anjani", LastName = "Bery", Address = "231 Glengrove Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-10-11 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Anjani", LastName = "Bery", Birthday = DateTime.Parse("12-24-1954"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Anand", LastName = "Bery", Birthday = DateTime.Parse("10-21-1994"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("02-17-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Areti", LastName = "Berdoussis", Address = "104 Bedford Park Ave", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 31, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Areti", LastName = "Berdoussis", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Louis", LastName = "", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Avelina", LastName = "Javonillo", Address = "65 Crotean Cres", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 40, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-10 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Avelina", LastName = "Javonillo", Birthday = DateTime.Parse("11-10-1959"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Sergio", LastName = "Javonillo", Birthday = DateTime.Parse("10-07-1962"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Dina", LastName = "Baybayan", Birthday = DateTime.Parse("05-20-1967"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Camille", LastName = "Anne Javonillo", Birthday = DateTime.Parse("04-28-1998"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Collin", LastName = "George Javonillo", Birthday = DateTime.Parse("07-10-2003"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-10-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-10-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("05-23-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Bongsu", LastName = "Kim", Address = "Pick Up / Drop Off ONLY", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Buenasol", LastName = "Uy", Address = "57 Amherst Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 28, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Buenasol", LastName = "Uy", Birthday = DateTime.Parse("07-14-1970"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Honesto", LastName = "Uy", Birthday = DateTime.Parse("11-11-1964"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Hannie", LastName = "Uy", Birthday = DateTime.Parse("04-05-1998"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Levi", LastName = "Uy", Birthday = DateTime.Parse("10-05-2000"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ace", LastName = "Uy", Birthday = DateTime.Parse("02-20-2003"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-02-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("02-13-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Charito", LastName = "Macaraeg", Address = "1506-3636 Bathurst St", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 32, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-12-06 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Charito", LastName = "Macaraeg", Birthday = DateTime.Parse("02-20-1975"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-11-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Dale", LastName = "Faulkner", Address = "5 Savoy Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 36, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-05 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Dale", LastName = "Faulkner", Birthday = DateTime.Parse("07-20-1967"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Allan", LastName = "Schuler", Birthday = DateTime.Parse("07-21-1965"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-28-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-28-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Elinore", LastName = "Ambray", Address = "2500 Keele St", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 36, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-30 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Elinore", LastName = "Ambray", Birthday = DateTime.Parse("07-11-1960"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("10-15-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Elmarie", LastName = "Dalog", Address = "160 Caines Ave", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 26, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Elmarie", LastName = "Dalog", Birthday = DateTime.Parse("01-08-1979"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Sunshine", LastName = "Dalog", Birthday = DateTime.Parse("02-15-2000"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Erlinda", LastName = "Llemos", Address = "43 Mabley Cres", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 30, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-01-27 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Erlinda", LastName = "Llemos", Birthday = DateTime.Parse("01-29-1955"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Etelvina", LastName = "Igreda", Address = "24 Goodwill Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 24, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Etelvina", LastName = "Igreda", Birthday = DateTime.Parse("04-20-1977"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Steven", LastName = "Robertson", Birthday = DateTime.Parse("06-29-1977"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Sofia", LastName = "Robertson", Birthday = DateTime.Parse("04-14-2009"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Allister", LastName = "Robertson", Birthday = DateTime.Parse("01-15-2011"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Laura", LastName = "Robertson", Birthday = DateTime.Parse("01-03-2014"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Faustina", LastName = "Valencia", Address = "50 Touchstone Dr", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 29, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Faustina", LastName = "Valencia", Birthday = DateTime.Parse("02-15-1966"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Emmanuel", LastName = "Valencia", Birthday = DateTime.Parse("07-27-1963"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "John", LastName = "Paolo Valencia", Birthday = DateTime.Parse("12-14-1994"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Pauline", LastName = "Ann Valencia", Birthday = DateTime.Parse("07-04-1994"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Patty", LastName = "Leica Valencia", Birthday = DateTime.Parse("10-28-2000"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Marta", LastName = "Espanola", Birthday = DateTime.Parse("01-19-1947"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-02-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-03-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Gaye", LastName = "Acarman Guney", Address = "17 Beethoven Crt", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 23, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Gaye", LastName = "Acarman", Birthday = DateTime.Parse("04-06-1970"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ercan", LastName = "Guney", Birthday = DateTime.Parse("06-05-1970"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Gloria", LastName = "Doyle", Address = "2 Common Wealth Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 35, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-07-06 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Gloria", LastName = "Doyle", Birthday = DateTime.Parse("12-29-1959"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Brian", LastName = "Ngui-Yen", Birthday = DateTime.Parse("12-02-1954"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-16-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-16-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Imelda", LastName = "Latayan", Address = "16 Dove Hawkway", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 28, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-12-19 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Imelda", LastName = "Latayan", Birthday = DateTime.Parse("01-19-1975"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Roalin", LastName = "Cacayurin", Birthday = DateTime.Parse("04-29-1976"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-10-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-11-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Jaeyoung", LastName = "Ban", Address = "Pick Up / Drop Off ONLY", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "James", LastName = "Bol", Address = "223 Robert Hicks Dr", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 37, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "James", LastName = "Bol", Birthday = DateTime.Parse("11-11-1955"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Rajini", LastName = "Bol", Birthday = DateTime.Parse("07-17-1965"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Corinth", LastName = "Ryan Bol", Birthday = DateTime.Parse("07-30-1994"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-07-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-07-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Jocelyn", LastName = "G. Getutua", Address = "1708-100 Antibes Dr", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 30, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Jocelyn", LastName = "Getutua", Birthday = DateTime.Parse("01-30-1963"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Nicasio", LastName = "Getutua", Birthday = DateTime.Parse("10-11-1961"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Joe", LastName = "Micner", Address = "108 Mullen Dr", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 30, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-05-22 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Judy", LastName = "Micner", Birthday = DateTime.Parse("02-08-1949"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Joe", LastName = "Micner", Birthday = DateTime.Parse("07-04-1950"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-23-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-23-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Josefina", LastName = "Rosil", Address = "19 Tilbury Dr", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 35, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Josefina", LastName = "Rosil", Birthday = DateTime.Parse("03-19-1958"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Eduardo", LastName = "Rosil", Birthday = DateTime.Parse("10-31-1962"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Nathalie", LastName = "Eden Rosil", Birthday = DateTime.Parse("12-15-1996"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Eduard", LastName = "Rosil", Birthday = DateTime.Parse("02-12-2001"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-02-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-13-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-02-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Lorena", LastName = "Manganaan", Address = "73 Wilmont", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 28, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-07-06 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Lorena", LastName = "Manganaan", Birthday = DateTime.Parse("11-06-1978"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jeremy", LastName = "Manganaan", Birthday = DateTime.Parse("03-24-1976"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jonas", LastName = "Manganaan", Birthday = DateTime.Parse("09-18-2008"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Lorna", LastName = "Blennerhassett", Address = "40 Risebroough Ave", Language = "English", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 33, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-18 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Lorna", LastName = "Blennerhassett", Birthday = DateTime.Parse("09-24-1954"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "John", LastName = "Blennerhassett", Birthday = DateTime.Parse("03-09-1956"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-08-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-17-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Mahrokh", LastName = "Norouzi", Address = "11 Cherrystone Dr", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 32, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-12-02 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Mahrokh", LastName = "Norouzi", Birthday = DateTime.Parse("01-03-1957"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Nick", LastName = "Nikoui", Birthday = DateTime.Parse("02-01-1956"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-12-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-12-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Maria", LastName = "De Araujo", Address = "18 Talbot St", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 28, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Maria", LastName = "De Araujo", Birthday = DateTime.Parse("04-20-1960"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-17-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Marie", LastName = "Villasanta", Address = "4239 Dufferin St", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 38, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Marie", LastName = "Villasanta", Birthday = DateTime.Parse("11-11-1956"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jaime", LastName = "Villasanta", Birthday = DateTime.Parse("04-25-1953"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Marjorie", LastName = "Castro", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Roger", LastName = "Quilala", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Elsie", LastName = "Castro", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Elmer", LastName = "Bernardino", Birthday = DateTime.Parse("01-01-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-10-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Melissa", LastName = "Slater", Address = "24 Robinwood Trail", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 31, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-07-06 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Melissa", LastName = "Slater", Birthday = DateTime.Parse("01-15-1959"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Gary", LastName = "Slater", Birthday = DateTime.Parse("12-21-1952"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Wesley", LastName = "Slater", Birthday = DateTime.Parse("10-18-1985"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Shane", LastName = "Slater", Birthday = DateTime.Parse("09-16-1987"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-24-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-26-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-25-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-03-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Mercedita", LastName = "Guimban", Address = "29 Canoy Courtway", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 39, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-11 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Mercedita", LastName = "Guimban", Birthday = DateTime.Parse("02-21-1972"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Roderick", LastName = "Guimban", Birthday = DateTime.Parse("10-24-1972"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Robmon", LastName = "Guimban", Birthday = DateTime.Parse("11-17-2004"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Remcy", LastName = "Guimban", Birthday = DateTime.Parse("12-19-2006"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("12-04-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-20-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Mila", LastName = "Yabis", Address = "238 Chisholm Ave", Language = "", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 34, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-09 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Mila", LastName = "Yabis", Birthday = DateTime.Parse("04-23-1959"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Elawad", LastName = "Khalid", Birthday = DateTime.Parse("07-01-1962"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Sarah", LastName = "Khalid", Birthday = DateTime.Parse("03-11-1995"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Mona", LastName = "Khalid", Birthday = DateTime.Parse("12-05-1996"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Nelida", LastName = "Panday", Address = "1202-5 Brookbanks Dr", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 26, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-07-08 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Nelida", LastName = "Panday", Birthday = DateTime.Parse("03-24-1958"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Neriza", LastName = "Jara", Address = "13 Centrepark Dr", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 26, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Neriza", LastName = "Jara", Birthday = DateTime.Parse("12-07-1974"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jason", LastName = "Jara", Birthday = DateTime.Parse("12-07-1974"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Clarice", LastName = "Anna Jara", Birthday = DateTime.Parse("11-12-1998"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Aaron", LastName = "Morris Jara", Birthday = DateTime.Parse("08-29-2000"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-14-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Olivia", LastName = "Di Perra", Address = "66 Arieta Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 41, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-08-17 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Olivia", LastName = "Di Perra", Birthday = DateTime.Parse("06-12-1963"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Tony", LastName = "Di Perra", Birthday = DateTime.Parse("10-14-1966"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Francesca", LastName = "Di Perra", Birthday = DateTime.Parse("06-23-1997"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Joshua", LastName = "Di Perra", Birthday = DateTime.Parse("02-14-2004"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-14-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-15-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("10-29-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Sara", LastName = "Esra Sahin", Address = "378 Willowdale Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 41, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-20 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Sara", LastName = "Sahin", Birthday = DateTime.Parse("05-24-1976"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "John", LastName = "Ventura", Birthday = DateTime.Parse("08-12-1968"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Aiden", LastName = "Ventura", Birthday = DateTime.Parse("12-01-2012"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-16-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-16-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Sohan", LastName = "Singh", Address = "48 Phillip Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 37, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-09-09 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Sohan", LastName = "Singh", Birthday = DateTime.Parse("10-17-1962"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Victoria", LastName = "Singh", Birthday = DateTime.Parse("05-16-1997"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Rohan", LastName = "Singh", Birthday = DateTime.Parse("11-15-1994"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("09-15-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Teresa", LastName = "Alvarez", Address = "48 Beechborough Ave", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 33, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-06-18 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Teresa", LastName = "Alvarez", Birthday = DateTime.Parse("04-02-1961"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Sabina", LastName = "Alvarez", Birthday = DateTime.Parse("08-29-1930"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Maria", LastName = "Lagondis", Birthday = DateTime.Parse("07-03-1997"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Markella", LastName = "Lagondis", Birthday = DateTime.Parse("10-18-2000"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("10-15-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Tobi", LastName = "Sade", Address = "27 Laurelcrest Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 33, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-12-05 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Tobi", LastName = "Sade", Birthday = DateTime.Parse("07-30-1966"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Hanan", LastName = "Sade", Birthday = DateTime.Parse("02-11-1966"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Daniel", LastName = "Sade", Birthday = DateTime.Parse("07-02-1996"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-23-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-24-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-12-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Wilhelmina", LastName = "Susan Fischer", Address = "71 Glenshephard Dr", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 40, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-07-04 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Silhelmina", LastName = "Susan Fischer", Birthday = DateTime.Parse("09-18-1941"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-11-2012"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Leonila", LastName = "Solis", Address = "748 E 41st Ave", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Genevieve", LastName = "Manghi", Address = "836 5th St", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Mary", LastName = "Ann Cruz", Address = "7358 12th Ave", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Belen", LastName = "Madrigal", Address = "1305 7th Ave", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Evangeline", LastName = "Caampued", Address = "7506 4th St", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Josephine", LastName = "Domingo", Address = "2620 Turner St", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Teresa", LastName = "Guieb", Address = "2648 Turner St", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Liza", LastName = "Verdon", Address = "3494 Knight St", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Cherry", LastName = "Demegillo", Address = "5168 Sidley St", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Rowena", LastName = "Flores", Address = "2251 Mclennan Ave", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Linda", LastName = "Cipparrone", Address = "7307 McKay Ave", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Josie", LastName = "Huey", Address = "3211-240 Sherbrooke St", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Celia", LastName = "Seneca", Address = "5041 Manor St", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Slavica", LastName = "Maksimovic", Address = "8-805 Laguna Court", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Lizza", LastName = "Evans", Address = "7303 12th Avenue", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Alma", LastName = "Malig", Address = "1005 East King Edward Ave", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 24, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-08-10 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Alma", LastName = "Malig", Birthday = DateTime.Parse("10-15-1957"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Nemancio", LastName = "Malig", Birthday = DateTime.Parse("03-21-1955"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-14-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-14-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Ana", LastName = "Solidarios", Address = "3918 Nanaimo St", Language = "ESL", Students = "5+", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 25, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2014-01-27 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Ana", LastName = "Solidarios", Birthday = DateTime.Parse("08-17-1958"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Luis", LastName = "Solidarios", Birthday = DateTime.Parse("03-14-1958"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-22-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-22-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Angelita", LastName = "Rivera", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Audrey", LastName = "Eday", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Domenica", LastName = "Bevacqua", Address = "3575 East 23rd Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 26, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-08-17 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Domenica", LastName = "Bevacqua", Birthday = DateTime.Parse("08-08-1970"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-10-2014"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Elizabeth", LastName = "Cerezo", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Elizabeth", LastName = "Lazona", Address = "7252 11th Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 26, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-08-30 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Elizabeth", LastName = "Lazona", Birthday = DateTime.Parse("03-22-1971"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Melba", LastName = "Yagyagan", Birthday = DateTime.Parse("03-05-1971"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ruby", LastName = "John Lazona", Birthday = DateTime.Parse("06-07-1994"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("10-07-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("03-27-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Eva", LastName = "Fernandez", Address = "3871 Elmwood St", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 24, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-08-24 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Eva", LastName = "Fernandez", Birthday = DateTime.Parse("12-04-1952"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jose", LastName = "Fernandez", Birthday = DateTime.Parse("03-19-1948"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Chester", LastName = "Fernandez", Birthday = DateTime.Parse("05-07-1978"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Maricel", LastName = "Fernandez", Birthday = DateTime.Parse("04-28-1977"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Rydiel", LastName = "Fernandez", Birthday = DateTime.Parse("03-28-2014"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Christian", LastName = "Fernandez", Birthday = DateTime.Parse("04-07-1979"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Filipinas", LastName = "Caliwag", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Josefa", LastName = "Secretaria", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Josephine", LastName = "Balasico", Address = "2-935 Ewen Ave", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 26, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-08-21 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Josephine", LastName = "Balasico", Birthday = DateTime.Parse("03-07-1964"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Roochie", LastName = "R. Cuayzon", Birthday = DateTime.Parse("06-01-1976"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-21-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-21-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Josephine", LastName = "Dela Cruz", Address = "208 43rd Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 26, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-08-19 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Josephine", LastName = "Dela Cruz", Birthday = DateTime.Parse("06-30-1960"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ruben", LastName = "Dela Cruz", Birthday = DateTime.Parse("05-23-1959"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-05-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("07-04-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Julienne", LastName = "Del-Isen", Address = "4065 Windsor St", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 24, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-08-21 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Julienne", LastName = "Del-Isen", Birthday = DateTime.Parse("10-15-1970"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Faith", LastName = "Del-Isen", Birthday = DateTime.Parse("03-2002"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("02-16-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Irma", LastName = "Caringal", Address = "5394 Cecil St", Language = "ESL", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 26, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-08-11 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Irma", LastName = "Caringal", Birthday = DateTime.Parse("04-06-1954"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Nicetas", LastName = "Caringal", Birthday = DateTime.Parse("03-20-1957"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Marlon", LastName = "John Caringal", Birthday = DateTime.Parse("09-10-1989"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Mariness", LastName = "Caringal", Birthday = DateTime.Parse("12-22-1992"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-22-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-01-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-12-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("06-01-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Lilia", LastName = "Seguin", Address = "1350 East 61st Ave", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 21, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-07-05 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Lilia", LastName = "Seguin", Birthday = DateTime.Parse("11-11-1956"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Francis", LastName = "Seguin", Birthday = DateTime.Parse("08-31-1980"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Kathleen", LastName = "Plan Seguin", Birthday = DateTime.Parse("05-1985"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Kedrict", LastName = "Seguin", Birthday = DateTime.Parse("08-30-2005"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-27-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Lina", LastName = "Bevacqua", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Lorna", LastName = "Bulaclac", Address = "670 East 64th Ave", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 26, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2015-10-23 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Lorna", LastName = "Buaclac", Birthday = DateTime.Parse("03-12-1964"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Russell", LastName = "Paul", Birthday = DateTime.Parse("01-04-1972"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Shaine", LastName = "Bulaclac", Birthday = DateTime.Parse("04-03-2004"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-26-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-15-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Nilda", LastName = "Jimenez", Address = "6083 Sprott St", Language = "ESL", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 21, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-06-02 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Nilda", LastName = "Jimenez", Birthday = DateTime.Parse("06-12-1959"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Florentino", LastName = "Jimenez", Birthday = DateTime.Parse("03-14-1955"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Phillip", LastName = "Jimenez", Birthday = DateTime.Parse("03-25-1998"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Florentino", LastName = "Jr Jimenez", Birthday = DateTime.Parse("04-01-2000"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-15-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("09-07-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Perla", LastName = "Lasaleta", Address = "6505 Lancaster St", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 26, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-08-25 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Perla", LastName = "Lasaleta", Birthday = DateTime.Parse("03-28-1951"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Richard", LastName = "Lasaleta", Birthday = DateTime.Parse("04-28-1949"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Rosinni", LastName = "Pasuelo", Birthday = DateTime.Parse("05-24-1978"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-21-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-20-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Rita", LastName = "Rematore", Address = "6916 Beatrice St", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 26, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-08-16 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Rita", LastName = "Rematore", Birthday = DateTime.Parse("07-21-1970"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Ronnie", LastName = "Chand", Birthday = DateTime.Parse("04-15-1968"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Brandon", LastName = "Chand", Birthday = DateTime.Parse("02-06-1996"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Bradley", LastName = "Chand", Birthday = DateTime.Parse("09-03-2004"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("09-15-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("09-15-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("09-15-2015"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Rodrigo", LastName = "Cabusao", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Romilda", LastName = "Adan", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Rose", LastName = "Pulmano", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Ruby", LastName = "Papilla", Address = "7491 12th Ave", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 21, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-08-18 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Ruby", LastName = "Papilla", Birthday = DateTime.Parse("03-31-1956"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Mario", LastName = "Papilla", Birthday = DateTime.Parse("05-24-1957"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Christian", LastName = "Kyle Papilla", Birthday = DateTime.Parse("09-10-1990"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Jonah", LastName = "Spencer Papilla", Birthday = DateTime.Parse("11-17-2000"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-08-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("11-09-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Shelina", LastName = "Virani", Address = "7620 Rosewood St", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 28, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-08-10 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Shelina", LastName = "Virani", Birthday = DateTime.Parse("01-16-1965"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("01-27-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Shirley", LastName = "Luspo", Address = "5435 Dominion St", Language = "English", Students = "1 to 2", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 21, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-08-19 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Shirley", LastName = "Luspo", Birthday = DateTime.Parse("08-27-1958"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Orlando", LastName = "Luspo", Birthday = DateTime.Parse("05-28-1953"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Shela", LastName = "Luspo", Birthday = DateTime.Parse("12-02-2000"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayHouseHold() { FirstName = "Trisha", LastName = "Luspo", Birthday = DateTime.Parse("03-18-2005"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("05-03-2013"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("04-04-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Susana", LastName = "Mondejar", Address = "147 63rd Ave", Language = "English", Students = "3 to 4", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                    HomestayEvaluations = new List<HomestayEvaluation>() { new HomestayEvaluation() { EvaluationDate = DateTime.Now, Location = 24, CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayContracts = new List<HomestayContract>() { new HomestayContract() { ContractDate = DateTime.Parse("2016-08-24 12:00:00 AM"), CreatedDate = DateTime.Now, CreatedUserId = 1 } },
                    HomestayHouseHolds = new List<HomestayHouseHold>() {
                        new HomestayHouseHold() { FirstName = "Susana", LastName = "Mondejar", Birthday = DateTime.Parse("12-26-1961"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                    HomestayPoliceChecks = new List<HomestayPoliceCheck>() {
                        new HomestayPoliceCheck() { PoliceCheckDate = DateTime.Parse("08-21-2016"), CreatedDate = DateTime.Now, CreatedUserId = 1 },
                    },
                },

                new Homestay() { FirstName = "Victoria", LastName = "Manzon", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

                new Homestay() { FirstName = "Won", LastName = "Ho Son", Address = "", Language = "", Students = "", Phone = "(111) 111-1111", PostCode = "A1A1A1", Room = 0, VideoUrl = "", CreatedDate = DateTime.Now, CreatedUserId = 1,
                },

            };
            _context.Homestays.AddRange(homestays);
            _context.SaveChanges();
        }

        public void AddStudents()
        {
            var secToronto = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "SEC-UCCBT");
            var cacToronto = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "CAC");
            var pgicToronto = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "PGIC");
            var kgicToronto = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "KGIC");
            var secVancouver = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "SEC-UCCBT");
            var kgicSurrey = _context.SiteLocations.FirstOrDefault(x => x.Name == "Surrey" && x.Site.Name == "KGIC");
            var kgicVancouver = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "KGIC");
            var kgicVictoria = _context.SiteLocations.FirstOrDefault(x => x.Name == "Victoria" && x.Site.Name == "KGIC");
            var pgicVancouver = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "PGIC");

            var students = new List<Student>
            {

                new Student() { FirstName = "Leslie Stephanie", LastName = "Perez Campos", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Jenniffer", LastName = "Fontes Gaisler", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Mohanad", LastName = "Bahafi", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Mathilda", LastName = "Messaggi Brioschi", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Maely", LastName = "Coutinho Perestrelo", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Tina", LastName = "Todte", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Erica", LastName = "Nardi", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Kellin", LastName = "Keller", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Marcela", LastName = "Fajardo Dulcey", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Manuel", LastName = "Larrea Galindo", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Julian David", LastName = "Ortiz Cardenas", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Rodrigues", LastName = "Wellington Costa", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Natalia", LastName = "Mafar Goncalves", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Susana", LastName = "Varela", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Pedro", LastName = "Pinto Monteiro", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Robert", LastName = "Heiliger", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Christopher", LastName = "Montoison", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Simone", LastName = "Satta", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Dominik", LastName = "Lupino", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Samara", LastName = "Assis", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Pablo", LastName = "Perez Diaz", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Marcos Roberto", LastName = "Gomes de Moura", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Maiara Deriane", LastName = "Ramos Menezes", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Roberta Correa", LastName = "Barcelos de Oliveira", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Daniel", LastName = "Mariano Macedo", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Jair", LastName = "Macedo", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Robson", LastName = "", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Shoma", LastName = "", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Jean M", LastName = "R Alvarez", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Alessandro", LastName = "Da Silveira Mendes", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "", LastName = "Guilherme", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Daniel", LastName = "Freire", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Kaho", LastName = "Mamimura", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "", LastName = "Sidelene", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Celia Berenice", LastName = "Medina Ortega", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Johana Angelica", LastName = "Gonzalez Ramos", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Diogo", LastName = "Yoshikazu Ujihara", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Evellin", LastName = "da Silva Brunholi", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Leandro", LastName = "Oliveira", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Johana", LastName = "Ramos", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Mayeon", LastName = "Martendal", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Merve", LastName = "", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Mariana Dionisio", LastName = "Correa B Oliveira", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Thalita", LastName = "Oliveira Rodrigues", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Gabriela", LastName = "Schneider Gabel", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Beatriz", LastName = "Costa Pezarim", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Karina Romanha", LastName = "de Alcantara", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Claudia Andrea", LastName = "Téllez Jiménez", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Buket", LastName = "Erdogan", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = cacToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Fuka", LastName = "Nakagawa", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Beatriz", LastName = "dos Reis Da Paz", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Yuri", LastName = "Placa Stellar", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Khristos", LastName = "Zin", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Rosa Maria", LastName = "Eusquiano", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Rosa Maria", LastName = "Eusquiano", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Mako", LastName = "Toyoda", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Nandersson Melo", LastName = "Pimentel Da Rocha", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Guillermo", LastName = "Donnamaria Granzotti", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Rafael Martorano", LastName = "Gomes", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Guilherme", LastName = "Gomes Ribeiro", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Wagner", LastName = "da Cruz Freire", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Gabriela", LastName = "Conceicao Gomes", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Marcia", LastName = "Cristina de Menezes", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Mikami", LastName = "Yudai", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Alejandro Antonio", LastName = "Canoura Valera", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Oscar Javier", LastName = "Soriano Colmenares", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = pgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Paola Estefania", LastName = "Hernandez Rodriguez", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "David Ricardo", LastName = "Aguilar Farias", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Luis Eduardo", LastName = "Mendez Moreno", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Luisa", LastName = "Costa Brasiliense", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Larissa Haddad", LastName = "Vieira", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Che-Yu", LastName = "Shen", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Deniz", LastName = "Pehlivan", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Israel Ivan", LastName = "Aradillas Salas", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Bruna", LastName = "Vicenssotto Fiorentino", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Elida", LastName = "Flores", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Sergio Armando", LastName = "Cortes Butanda", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Ana Claudia", LastName = "Zambelli", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Leandro", LastName = "Zambelli", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Bakr Abu Bakr M", LastName = "Albarbakati", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Jose Alberto", LastName = "Perez Hernandez", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicToronto, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Rita", LastName = "de Cassia Wrobel", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Judith", LastName = "Ulbricht", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Laura Lena", LastName = "Becker", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Franziska", LastName = "Heimlich", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Stephanie", LastName = "Moesching", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Jesus", LastName = "Morales Aguilar", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Julia", LastName = "Seidel", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Romy Annette", LastName = "Strickert", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Flavia", LastName = "de Andrade Viveiros Quadrelli", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Nathalia Simi", LastName = "Braz Apra Medeiros", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Roberta", LastName = "Rodrigues dos Santos", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Nathalia Simi", LastName = "Braz Apra Medeiros", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Thiago", LastName = "de Lima Tota", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Gustavo Ebecken", LastName = "De Gusmao", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Alice", LastName = "Copette", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Natalia Marinho", LastName = "Lioi Nascent", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Thomas", LastName = "Scheidel", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Guerkan", LastName = "Kuecuekkoese", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Humberto", LastName = "Vitale", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Lena", LastName = "Huber", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Erika", LastName = "Haag", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Andrea Maria", LastName = "Okle", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Jeanine Andrea", LastName = "Okle", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = secVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Ryo", LastName = "YAMASAKI", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Yulu", LastName = "HAO", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Jumpei", LastName = "KAWAGUCHI", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Mei", LastName = "HIRAKAWA", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Taiki", LastName = "MIURA", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Erika", LastName = "AKIYAMA", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Momoka", LastName = "IIZUKA", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Yuro", LastName = "AOKI", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Shintaro", LastName = "KOBAYASHI", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Maria Renata", LastName = "SALAZAR RODRIGUEZ", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Han-Yin", LastName = "LI", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Kazuki", LastName = "HIROSE", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Kosuke", LastName = "NISHIMORI", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Mio", LastName = "SETO", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Isadora", LastName = "STORTI BELCHIOR PEREIRA", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Maria Fernanda", LastName = "CRUZ DANIEL", Address = string.Empty, PostCode = "A1A1A1", Gender = false, Phone = "(111) 111-1111", SiteLocation = kgicSurrey, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Jee Hye", LastName = "Hong", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "", LastName = "RO160569", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Nahee", LastName = "Lee", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "", LastName = "RO142107", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Shinya", LastName = "Takizawa", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Shinto", LastName = "Yamaniha", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Yu-Wei", LastName = "Huang", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Chin-Tzu", LastName = "Chen", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Tatiana", LastName = "Mara Cintra", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "", LastName = "RO160603", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "", LastName = "RO151134", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "", LastName = "RO150927", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVancouver, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Chia-Feng", LastName = "Lee", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVictoria, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Wei-Ting", LastName = "Wu", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVictoria, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "", LastName = "VI160125", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVictoria, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Yi-Shan", LastName = "Li", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVictoria, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Cynthia Dariela", LastName = "Perez Ovalle", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVictoria, StudentNo = "0000", CreatedDate = DateTime.Now },

                new Student() { FirstName = "Yukiko", LastName = "Endo", Address = string.Empty, PostCode = "A1A1A1", Gender = true, Phone = "(111) 111-1111", SiteLocation = kgicVictoria, StudentNo = "0000", CreatedDate = DateTime.Now },

            };
            _context.Students.AddRange(students);
            _context.SaveChanges();
        }

        public void AddHomestayStudents()
        {
            var secToronto = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "SEC-UCCBT");
            var cacToronto = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "CAC");
            var pgicToronto = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "PGIC");
            var kgicToronto = _context.SiteLocations.FirstOrDefault(x => x.Name == "Toronto" && x.Site.Name == "KGIC");
            var secVancouver = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "SEC-UCCBT");
            var kgicSurrey = _context.SiteLocations.FirstOrDefault(x => x.Name == "Surrey" && x.Site.Name == "KGIC");
            var kgicVancouver = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "KGIC");
            var kgicVictoria = _context.SiteLocations.FirstOrDefault(x => x.Name == "Victoria" && x.Site.Name == "KGIC");
            var pgicVancouver = _context.SiteLocations.FirstOrDefault(x => x.Name == "Vancouver" && x.Site.Name == "PGIC");

            HomestayStudent homestayStudent;
            Student student = null;
            Homestay homestay;


            student = _context.Students.FirstOrDefault(x => x.FirstName == "Leslie Stephanie" && x.LastName == "Perez Campos" && x.Gender == false && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Marites" && x.LastName == "Celestial");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-29 12:00:00 AM"), Departure = DateTime.Parse("2016-11-26 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 750M, Amount = 750M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Leslie Stephanie" && x.LastName == "Perez Campos" && x.Gender == false && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Marites" && x.LastName == "Celestial");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-01 12:00:00 AM"), Departure = DateTime.Parse("2016-10-29 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 750M, Amount = 750M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Jenniffer" && x.LastName == "Fontes Gaisler" && x.Gender == false && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Mary" && x.LastName == "Jane Bantolinao");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-30 12:00:00 AM"), Departure = DateTime.Parse("2016-11-27 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 700M, Amount = 700M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Mohanad" && x.LastName == "Bahafi" && x.Gender == true && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Jerry" && x.LastName == "Rodulfa");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-12 12:00:00 AM"), Departure = DateTime.Parse("2017-04-22 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 700M, Amount = 700M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Mathilda" && x.LastName == "Messaggi Brioschi" && x.Gender == false && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Margielyn" && x.LastName == "Provido");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-24 12:00:00 AM"), Departure = DateTime.Parse("2016-11-19 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 700M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Maely" && x.LastName == "Coutinho Perestrelo" && x.Gender == false && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Margielyn" && x.LastName == "Provido");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-27 12:00:00 AM"), Departure = DateTime.Parse("2016-09-24 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 700M, Amount = 700M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Tina" && x.LastName == "Todte" && x.Gender == false && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Margielyn" && x.LastName == "Provido");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-19 12:00:00 AM"), Departure = DateTime.Parse("2016-10-11 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 321M, Amount = 321M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Erica" && x.LastName == "Nardi" && x.Gender == false && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Gwen" && x.LastName == "Edamura");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-07 12:00:00 AM"), Departure = DateTime.Parse("2016-12-03 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 750M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Kellin" && x.LastName == "Keller" && x.Gender == false && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Guillermo" && x.LastName == "Nabong");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-17 12:00:00 AM"), Departure = DateTime.Parse("2016-10-15 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 700M, Amount = 700M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Kellin" && x.LastName == "Keller" && x.Gender == false && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Guillermo" && x.LastName == "Nabong");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-15 12:00:00 AM"), Departure = DateTime.Parse("2016-11-12 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 700M, Amount = 700M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Marcela" && x.LastName == "Fajardo Dulcey" && x.Gender == false && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lolita" && x.LastName == "Miclat");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-11-12 12:00:00 AM"), Departure = DateTime.Parse("2016-12-10 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 750M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Manuel" && x.LastName == "Larrea Galindo" && x.Gender == true && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lolita" && x.LastName == "Miclat");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-06 12:00:00 AM"), Departure = DateTime.Parse("2016-08-27 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 562.5M, Amount = 562M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Julian David" && x.LastName == "Ortiz Cardenas" && x.Gender == true && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Thelma" && x.LastName == "Black");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-11-18 12:00:00 AM"), Departure = DateTime.Parse("2016-12-16 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Rodrigues" && x.LastName == "Wellington Costa" && x.Gender == true && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Thelma" && x.LastName == "Black");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-06 12:00:00 AM"), Departure = DateTime.Parse("2016-09-02 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 700M, Amount = 700M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Natalia" && x.LastName == "Mafar Goncalves" && x.Gender == false && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Thelma" && x.LastName == "Black");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-07-30 12:00:00 AM"), Departure = DateTime.Parse("2016-08-01 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 26.78M, Amount = 26.78M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Susana" && x.LastName == "Varela" && x.Gender == false && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Thelma" && x.LastName == "Black");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-10 12:00:00 AM"), Departure = DateTime.Parse("2016-08-13 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 80.34M, Amount = 80.34M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Pedro" && x.LastName == "Pinto Monteiro" && x.Gender == true && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Thelma" && x.LastName == "Black");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-01 12:00:00 AM"), Departure = DateTime.Parse("2016-10-29 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 750M, Amount = 750M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Robert" && x.LastName == "Heiliger" && x.Gender == true && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Michael" && x.LastName == "Claxton");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-11-19 12:00:00 AM"), Departure = DateTime.Parse("2016-12-18 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 750M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Christopher" && x.LastName == "Montoison" && x.Gender == true && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Michael" && x.LastName == "Claxton");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-07-30 12:00:00 AM"), Departure = DateTime.Parse("2016-08-20 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 525M, Amount = 525M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Simone" && x.LastName == "Satta" && x.Gender == false && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Michael" && x.LastName == "Claxton");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-07 12:00:00 AM"), Departure = DateTime.Parse("2016-08-14 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 175M, Amount = 175M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Dominik" && x.LastName == "Lupino" && x.Gender == true && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Michael" && x.LastName == "Claxton");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-24 12:00:00 AM"), Departure = DateTime.Parse("2016-10-08 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 375M, Amount = 375M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Samara" && x.LastName == "Assis" && x.Gender == false && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lilibeth" && x.LastName == "Caacbay");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-11-12 12:00:00 AM"), Departure = DateTime.Parse("2016-12-10 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Pablo" && x.LastName == "Perez Diaz" && x.Gender == true && x.SiteLocation == secToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lilibeth" && x.LastName == "Caacbay");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-17 12:00:00 AM"), Departure = DateTime.Parse("2016-09-13 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 750M, Amount = 750M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Marcos Roberto" && x.LastName == "Gomes de Moura" && x.Gender == true && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Connie" && x.LastName == "Tizon");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-11-05 12:00:00 AM"), Departure = DateTime.Parse("2016-12-03 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 800M, Amount = 800M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Maiara Deriane" && x.LastName == "Ramos Menezes" && x.Gender == false && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Connie" && x.LastName == "Tizon");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-12-04 12:00:00 AM"), Departure = DateTime.Parse("2017-01-07 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Roberta Correa" && x.LastName == "Barcelos de Oliveira" && x.Gender == false && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lisa" && x.LastName == "Conover");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-28 12:00:00 AM"), Departure = DateTime.Parse("2016-11-25 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 730M, Amount = 730M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Daniel" && x.LastName == "Mariano Macedo" && x.Gender == true && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lisa" && x.LastName == "Conover");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2017-01-08 12:00:00 AM"), Departure = DateTime.Parse("2017-02-17 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Jair" && x.LastName == "Macedo" && x.Gender == true && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lisa" && x.LastName == "Conover");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-16 12:00:00 AM"), Departure = DateTime.Parse("2016-11-13 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 730M, Amount = 730M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Robson" && x.LastName == "" && x.Gender == true && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lisa" && x.LastName == "Conover");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-18 12:00:00 AM"), Departure = DateTime.Parse("2016-10-15 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 725M, Amount = 725M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Shoma" && x.LastName == "" && x.Gender == true && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lisa" && x.LastName == "Conover");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-18 12:00:00 AM"), Departure = DateTime.Parse("2016-10-15 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 705M, Amount = 705M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Jean M" && x.LastName == "R Alvarez" && x.Gender == false && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lisa" && x.LastName == "Conover");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-07-16 12:00:00 AM"), Departure = DateTime.Parse("2016-09-24 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 590M, Amount = 590M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Alessandro" && x.LastName == "Da Silveira Mendes" && x.Gender == true && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Maroulla" && x.LastName == "Andreou");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-16 12:00:00 AM"), Departure = DateTime.Parse("2017-02-10 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 6683.5M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "" && x.LastName == "Guilherme" && x.Gender == true && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Teresa" && x.LastName == "Alvarez");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-18 12:00:00 AM"), Departure = DateTime.Parse("2016-10-16 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 550M, Amount = 550M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Daniel" && x.LastName == "Freire" && x.Gender == true && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "" && x.LastName == "");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-07 12:00:00 AM"), Departure = DateTime.Parse("2016-11-04 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 730M, Amount = 730M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Kaho" && x.LastName == "Mamimura" && x.Gender == true && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "" && x.LastName == "");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-13 12:00:00 AM"), Departure = DateTime.Parse("2016-09-11 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 828.75M, Amount = 828.75M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "" && x.LastName == "Sidelene" && x.Gender == true && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "" && x.LastName == "");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-02 12:00:00 AM"), Departure = DateTime.Parse("2016-10-01 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 486.67M, Amount = 486.67M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Celia Berenice" && x.LastName == "Medina Ortega" && x.Gender == false && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "" && x.LastName == "");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-16 12:00:00 AM"), Departure = DateTime.Parse("2016-12-10 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 1435M, Amount = 1435M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Johana Angelica" && x.LastName == "Gonzalez Ramos" && x.Gender == false && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Gordana" && x.LastName == "Cafarelli");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-11-10 12:00:00 AM"), Departure = DateTime.Parse("2016-11-26 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 457.5M, Amount = 457.5M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Diogo" && x.LastName == "Yoshikazu Ujihara" && x.Gender == true && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Gordana" && x.LastName == "Cafarelli");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-12-03 12:00:00 AM"), Departure = DateTime.Parse("2017-02-04 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Evellin" && x.LastName == "da Silva Brunholi" && x.Gender == false && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Ivan" && x.LastName == "Saldana");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-12-11 12:00:00 AM"), Departure = DateTime.Parse("2017-01-14 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Leandro" && x.LastName == "Oliveira" && x.Gender == true && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Deborah" && x.LastName == "Moir");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-11-26 12:00:00 AM"), Departure = DateTime.Parse("2016-12-26 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Mariana Dionisio" && x.LastName == "Correa B Oliveira" && x.Gender == false && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Jasmin" && x.LastName == "Bulchand");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-11-30 12:00:00 AM"), Departure = DateTime.Parse("2016-12-25 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Thalita" && x.LastName == "Oliveira Rodrigues" && x.Gender == false && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Jasmin" && x.LastName == "Bulchand");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-12-03 12:00:00 AM"), Departure = DateTime.Parse("2016-12-31 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Gabriela" && x.LastName == "Schneider Gabel" && x.Gender == false && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Evangeline" && x.LastName == "Iquin");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2017-01-22 12:00:00 AM"), Departure = DateTime.Parse("2017-02-25 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Beatriz" && x.LastName == "Costa Pezarim" && x.Gender == false && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Evangeline" && x.LastName == "Iquin");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2017-01-22 12:00:00 AM"), Departure = DateTime.Parse("2017-02-25 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Karina Romanha" && x.LastName == "de Alcantara" && x.Gender == false && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Vidyo" && x.LastName == "Persaud");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2017-01-02 12:00:00 AM"), Departure = DateTime.Parse("2017-01-30 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Claudia Andrea" && x.LastName == "Téllez Jiménez" && x.Gender == false && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "David" && x.LastName == "Guvercin");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-12-05 12:00:00 AM"), Departure = DateTime.Parse("2017-01-07 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Buket" && x.LastName == "Erdogan" && x.Gender == true && x.SiteLocation == cacToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lilibeth" && x.LastName == "Caacbay");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-07-10 12:00:00 AM"), Departure = DateTime.Parse("2016-08-21 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Fuka" && x.LastName == "Nakagawa" && x.Gender == false && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Elias" && x.LastName == "Kaltsakos");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-29 12:00:00 AM"), Departure = DateTime.Parse("2016-11-16 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 991.24M, Amount = 991.24M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Beatriz" && x.LastName == "dos Reis Da Paz" && x.Gender == false && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Elias" && x.LastName == "Kaltsakos");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-29 12:00:00 AM"), Departure = DateTime.Parse("2016-11-16 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 991.24M, Amount = 991.24M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Beatriz" && x.LastName == "dos Reis Da Paz" && x.Gender == false && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Elias" && x.LastName == "Kaltsakos");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-29 12:00:00 AM"), Departure = DateTime.Parse("2016-11-16 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 750M, Amount = 750M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Yuri" && x.LastName == "Placa Stellar" && x.Gender == true && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Aurora" && x.LastName == "Somera");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-01 12:00:00 AM"), Departure = DateTime.Parse("2016-10-29 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 750M, Amount = 750M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Khristos" && x.LastName == "Zin" && x.Gender == true && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Amy" && x.LastName == "Trim");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-07 12:00:00 AM"), Departure = DateTime.Parse("2016-11-04 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 750M, Amount = 750M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Rosa Maria" && x.LastName == "Eusquiano" && x.Gender == true && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Nelson" && x.LastName == "Galang");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-09 12:00:00 AM"), Departure = DateTime.Parse("2016-10-29 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 562.5M, Amount = 562.5M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Rosa Maria" && x.LastName == "Eusquiano" && x.Gender == false && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Nelson" && x.LastName == "Galang");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-29 12:00:00 AM"), Departure = DateTime.Parse("2016-10-30 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 26.79M, Amount = 26.79M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Mako" && x.LastName == "Toyoda" && x.Gender == false && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Marites" && x.LastName == "Balura");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-29 12:00:00 AM"), Departure = DateTime.Parse("2016-11-25 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 750M, Amount = 750M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Beatriz" && x.LastName == "dos Reis Da Paz" && x.Gender == false && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Gloria" && x.LastName == "Manrique Santos");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-11-16 12:00:00 AM"), Departure = DateTime.Parse("2016-11-25 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 509M, Amount = 509M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Fuka" && x.LastName == "Nakagawa" && x.Gender == false && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Gloria" && x.LastName == "Manrique Santos");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-11-16 12:00:00 AM"), Departure = DateTime.Parse("2016-11-25 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 509M, Amount = 509M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Nandersson Melo" && x.LastName == "Pimentel Da Rocha" && x.Gender == true && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Rosalie" && x.LastName == "Miclat");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-31 12:00:00 AM"), Departure = DateTime.Parse("2016-11-27 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Guillermo" && x.LastName == "Donnamaria Granzotti" && x.Gender == true && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Alma" && x.LastName == "Ulob");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-24 12:00:00 AM"), Departure = DateTime.Parse("2016-11-20 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 780M, Amount = 780M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Rafael Martorano" && x.LastName == "Gomes" && x.Gender == true && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Alma" && x.LastName == "Ulob");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-30 12:00:00 AM"), Departure = DateTime.Parse("2016-11-26 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 750M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Guilherme" && x.LastName == "Gomes Ribeiro" && x.Gender == true && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Aurora" && x.LastName == "Somera");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-12-03 12:00:00 AM"), Departure = DateTime.Parse("2016-12-26 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Wagner" && x.LastName == "da Cruz Freire" && x.Gender == true && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Aurora" && x.LastName == "Somera");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-12-03 12:00:00 AM"), Departure = DateTime.Parse("2016-12-31 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Gabriela" && x.LastName == "Conceicao Gomes" && x.Gender == false && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Aurora" && x.LastName == "Somera");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-12-16 12:00:00 AM"), Departure = DateTime.Parse("2016-01-28 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Marcia" && x.LastName == "Cristina de Menezes" && x.Gender == false && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Ralph" && x.LastName == "Nacpil");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-11-27 12:00:00 AM"), Departure = DateTime.Parse("3016-12-24 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Gabriela" && x.LastName == "Conceicao Gomes" && x.Gender == false && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Ralph" && x.LastName == "Nacpil");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-12-16 12:00:00 AM"), Departure = DateTime.Parse("2016-01-28 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Mikami" && x.LastName == "Yudai" && x.Gender == true && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Maria" && x.LastName == "Luz Casareno");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-11-05 12:00:00 AM"), Departure = DateTime.Parse("2016-12-02 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 780M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Alejandro Antonio" && x.LastName == "Canoura Valera" && x.Gender == true && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Dominic" && x.LastName == "and Jessica Nater");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-27 12:00:00 AM"), Departure = DateTime.Parse("2016-11-23 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 780M, Amount = 780M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Oscar Javier" && x.LastName == "Soriano Colmenares" && x.Gender == true && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Maria" && x.LastName == "Calabrese");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-09 12:00:00 AM"), Departure = DateTime.Parse("2016-11-03 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Khristos" && x.LastName == "Zin" && x.Gender == true && x.SiteLocation == pgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Amy" && x.LastName == "Trim");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-11-04 12:00:00 AM"), Departure = DateTime.Parse("2016-12-02 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 750M, Amount = 750M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Paola Estefania" && x.LastName == "Hernandez Rodriguez" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lilibeth" && x.LastName == "Caacbay");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-15 12:00:00 AM"), Departure = DateTime.Parse("2016-12-31 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 820M, Amount = 820M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "David Ricardo" && x.LastName == "Aguilar Farias" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Belinda" && x.LastName == "Earle");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-13 12:00:00 AM"), Departure = DateTime.Parse("2017-02-03 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 828M, Amount = 800M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Luis Eduardo" && x.LastName == "Mendez Moreno" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Avelina" && x.LastName == "Javonillo");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-19 12:00:00 AM"), Departure = DateTime.Parse("2016-09-17 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Luisa" && x.LastName == "Costa Brasiliense" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Avelina" && x.LastName == "Javonillo");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-21 12:00:00 AM"), Departure = DateTime.Parse("2016-12-09 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Larissa Haddad" && x.LastName == "Vieira" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Melissa" && x.LastName == "Slater");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-30 12:00:00 AM"), Departure = DateTime.Parse("2016-11-27 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Che-Yu" && x.LastName == "Shen" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Anita" && x.LastName == "Soong");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-03 12:00:00 AM"), Departure = DateTime.Parse("2017-02-24 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 820M, Amount = 820M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Deniz" && x.LastName == "Pehlivan" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Maribel" && x.LastName == "Villasanta");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("0"), Departure = DateTime.Parse("0"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 800M, Amount = 800M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Deniz" && x.LastName == "Pehlivan" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Maribel" && x.LastName == "Villasanta");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("0"), Departure = DateTime.Parse("0"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 800M, Amount = 800M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Israel Ivan" && x.LastName == "Aradillas Salas" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Elinore" && x.LastName == "Ambray");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-07-09 12:00:00 AM"), Departure = DateTime.Parse("2016-08-05 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Bruna" && x.LastName == "Vicenssotto Fiorentino" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Adelpha" && x.LastName == "Delima");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-07 12:00:00 AM"), Departure = DateTime.Parse("2016-11-07 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 850M, Amount = 850M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Elida" && x.LastName == "Flores" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Adelpha" && x.LastName == "Delima");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-16 12:00:00 AM"), Departure = DateTime.Parse("2016-11-13 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 820M, Amount = 820M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Sergio Armando" && x.LastName == "Cortes Butanda" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Judy" && x.LastName == "+ Joe Micner");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-28 12:00:00 AM"), Departure = DateTime.Parse("2016-11-19 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Ana Claudia" && x.LastName == "Zambelli" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Mahrokh" && x.LastName == "Norouzi");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-23 12:00:00 AM"), Departure = DateTime.Parse("2016-10-22 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 671M, Amount = 671M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Leandro" && x.LastName == "Zambelli" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Mahrokh" && x.LastName == "Norouzi");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-23 12:00:00 AM"), Departure = DateTime.Parse("2016-10-22 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 671M, Amount = 671M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Bakr Abu Bakr M" && x.LastName == "Albarbakati" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Connie" && x.LastName == "Tizon");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-07-09 12:00:00 AM"), Departure = DateTime.Parse("2016-09-02 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 600M, Amount = 600M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Jose Alberto" && x.LastName == "Perez Hernandez" && x.Gender == true && x.SiteLocation == kgicToronto);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lorna" && x.LastName == "Blennerhassett");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-06 12:00:00 AM"), Departure = DateTime.Parse("2016-09-03 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Rita" && x.LastName == "de Cassia Wrobel" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Leonila" && x.LastName == "Solis");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-02 12:00:00 AM"), Departure = DateTime.Parse("2016-10-29 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 729M, Amount = 729M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Judith" && x.LastName == "Ulbricht" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Genevieve" && x.LastName == "Manghi");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-02 12:00:00 AM"), Departure = DateTime.Parse("2016-10-30 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 700M, Amount = 700M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Laura Lena" && x.LastName == "Becker" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Mary" && x.LastName == "Ann Cruz");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-27 12:00:00 AM"), Departure = DateTime.Parse("2016-09-17 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 567M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Franziska" && x.LastName == "Heimlich" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Mary" && x.LastName == "Ann Cruz");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-14 12:00:00 AM"), Departure = DateTime.Parse("2016-09-12 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 725M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Stephanie" && x.LastName == "Moesching" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Mary" && x.LastName == "Ann Cruz");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-07-09 12:00:00 AM"), Departure = DateTime.Parse("2016-08-06 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 50M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Stephanie" && x.LastName == "Moesching" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Mary" && x.LastName == "Ann Cruz");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-06 12:00:00 AM"), Departure = DateTime.Parse("2016-08-20 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 378M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Jesus" && x.LastName == "Morales Aguilar" && x.Gender == true && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Mary" && x.LastName == "Ann Cruz");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-07-31 12:00:00 AM"), Departure = DateTime.Parse("2016-08-28 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 750M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Julia" && x.LastName == "Seidel" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Belen" && x.LastName == "Madrigal");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-27 12:00:00 AM"), Departure = DateTime.Parse("2016-09-10 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 350M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Romy Annette" && x.LastName == "Strickert" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Belen" && x.LastName == "Madrigal");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-11 12:00:00 AM"), Departure = DateTime.Parse("2016-09-17 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 150M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Flavia" && x.LastName == "de Andrade Viveiros Quadrelli" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Belen" && x.LastName == "Madrigal");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-04 12:00:00 AM"), Departure = DateTime.Parse("2016-10-02 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 700M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Nathalia Simi" && x.LastName == "Braz Apra Medeiros" && x.Gender == true && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Evangeline" && x.LastName == "Caampued");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-17 12:00:00 AM"), Departure = DateTime.Parse("2016-09-21 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 100M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Roberta" && x.LastName == "Rodrigues dos Santos" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Teresa" && x.LastName == "Guieb");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-06 12:00:00 AM"), Departure = DateTime.Parse("2016-08-26 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 500M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Nathalia Simi" && x.LastName == "Braz Apra Medeiros" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Linda" && x.LastName == "Cipparrone");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-21 12:00:00 AM"), Departure = DateTime.Parse("2016-10-19 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 700M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Thiago" && x.LastName == "de Lima Tota" && x.Gender == true && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Josie" && x.LastName == "Huey");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-22 12:00:00 AM"), Departure = DateTime.Parse("2016-10-20 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 700M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Gustavo Ebecken" && x.LastName == "De Gusmao" && x.Gender == true && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Josie" && x.LastName == "Huey");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-17 12:00:00 AM"), Departure = DateTime.Parse("2016-08-26 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 540M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Alice" && x.LastName == "Copette" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Celia" && x.LastName == "Seneca");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-03 12:00:00 AM"), Departure = DateTime.Parse("2016-10-01 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 700M, Amount = 700M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Natalia Marinho" && x.LastName == "Lioi Nascent" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Celia" && x.LastName == "Seneca");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-06 12:00:00 AM"), Departure = DateTime.Parse("2016-08-26 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 540M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Thomas" && x.LastName == "Scheidel" && x.Gender == true && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Slavica" && x.LastName == "Maksimovic");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-24 12:00:00 AM"), Departure = DateTime.Parse("2016-10-08 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 350M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Guerkan" && x.LastName == "Kuecuekkoese" && x.Gender == true && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Slavica" && x.LastName == "Maksimovic");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-14 12:00:00 AM"), Departure = DateTime.Parse("2016-09-17 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 850M, Amount = 850M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Humberto" && x.LastName == "Vitale" && x.Gender == true && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Slavica" && x.LastName == "Maksimovic");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-10 12:00:00 AM"), Departure = DateTime.Parse("2016-10-08 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 700M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Lena" && x.LastName == "Huber" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lizza" && x.LastName == "Evans");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-11 12:00:00 AM"), Departure = DateTime.Parse("2016-09-25 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 350M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Erika" && x.LastName == "Haag" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lizza" && x.LastName == "Evans");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-11 12:00:00 AM"), Departure = DateTime.Parse("2016-09-21 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 250M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Andrea Maria" && x.LastName == "Okle" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lizza" && x.LastName == "Evans");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-28 12:00:00 AM"), Departure = DateTime.Parse("2016-09-09 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 300M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Jeanine Andrea" && x.LastName == "Okle" && x.Gender == false && x.SiteLocation == secVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Lizza" && x.LastName == "Evans");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-07-31 12:00:00 AM"), Departure = DateTime.Parse("2016-08-28 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 700M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Ryo" && x.LastName == "YAMASAKI" && x.Gender == true && x.SiteLocation == kgicSurrey);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Rasmia" && x.LastName == "Soliven");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-01-07 12:00:00 AM"), Departure = DateTime.Parse("2016-02-04 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 980M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Ryo" && x.LastName == "YAMASAKI" && x.Gender == true && x.SiteLocation == kgicSurrey);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Rasmia" && x.LastName == "Soliven");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-02-04 12:00:00 AM"), Departure = DateTime.Parse("2016-03-04 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 980M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Ryo" && x.LastName == "YAMASAKI" && x.Gender == true && x.SiteLocation == kgicSurrey);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Rasmia" && x.LastName == "Soliven");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-03-04 12:00:00 AM"), Departure = DateTime.Parse("2016-04-01 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 980M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Ryo" && x.LastName == "YAMASAKI" && x.Gender == true && x.SiteLocation == kgicSurrey);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Rasmia" && x.LastName == "Soliven");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-20 12:00:00 AM"), Departure = DateTime.Parse("2016-09-17 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 980M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Ryo" && x.LastName == "YAMASAKI" && x.Gender == true && x.SiteLocation == kgicSurrey);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Rasmia" && x.LastName == "Soliven");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-09-17 12:00:00 AM"), Departure = DateTime.Parse("2016-10-15 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 980M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Ryo" && x.LastName == "YAMASAKI" && x.Gender == true && x.SiteLocation == kgicSurrey);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Rasmia" && x.LastName == "Soliven");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-10-15 12:00:00 AM"), Departure = DateTime.Parse("2016-11-12 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 980M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Ryo" && x.LastName == "YAMASAKI" && x.Gender == true && x.SiteLocation == kgicSurrey);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Rasmia" && x.LastName == "Soliven");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-11-12 12:00:00 AM"), Departure = DateTime.Parse("2016-12-10 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 980M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Yulu" && x.LastName == "HAO" && x.Gender == true && x.SiteLocation == kgicSurrey);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Rasmia" && x.LastName == "Soliven");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-07 12:00:00 AM"), Departure = DateTime.Parse("2016-08-20 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 490M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Jumpei" && x.LastName == "KAWAGUCHI" && x.Gender == true && x.SiteLocation == kgicSurrey);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Matilda" && x.LastName == "Jallad");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-01 12:00:00 AM"), Departure = DateTime.Parse("2016-08-14 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 455M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Mei" && x.LastName == "HIRAKAWA" && x.Gender == false && x.SiteLocation == kgicSurrey);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Farina" && x.LastName == "Hussain");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-07-24 12:00:00 AM"), Departure = DateTime.Parse("2016-08-07 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 490M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Taiki" && x.LastName == "MIURA" && x.Gender == true && x.SiteLocation == kgicSurrey);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Angela" && x.LastName == "Singh");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-08-13 12:00:00 AM"), Departure = DateTime.Parse("2016-08-27 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 490M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Erika" && x.LastName == "AKIYAMA" && x.Gender == false && x.SiteLocation == kgicSurrey);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Cristina" && x.LastName == "Bonilla");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-07-31 12:00:00 AM"), Departure = DateTime.Parse("2016-08-12 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 420M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Yuro" && x.LastName == "AOKI" && x.Gender == true && x.SiteLocation == kgicSurrey);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Maria" && x.LastName == "Luz DELOS SANTOS");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("2016-07-02 12:00:00 AM"), Departure = DateTime.Parse("2016-07-06 12:00:00 AM"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 175M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Jee Hye" && x.LastName == "Hong" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Josephine" && x.LastName == "Balasico");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("11-20-2016"), Departure = DateTime.Parse("12-03-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 380.74M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Jee Hye" && x.LastName == "Hong" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Josephine" && x.LastName == "Balasico");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("10-23-2016"), Departure = DateTime.Parse("11-20-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 820M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Jee Hye" && x.LastName == "Hong" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Josephine" && x.LastName == "Balasico");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("09-11-2016"), Departure = DateTime.Parse("10-23-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 1230M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "" && x.LastName == "RO160569" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Josephine" && x.LastName == "Balasico");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("09-24-2016"), Departure = DateTime.Parse("10-16-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 820M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Nahee" && x.LastName == "Lee" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Julienne" && x.LastName == "Del-Isen");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("11-20-2016"), Departure = DateTime.Parse("12-03-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 380.74M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Nahee" && x.LastName == "Lee" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Julienne" && x.LastName == "Del-Isen");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("10-23-2016"), Departure = DateTime.Parse("11-20-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 820M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Nahee" && x.LastName == "Lee" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Julienne" && x.LastName == "Del-Isen");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("09-11-2016"), Departure = DateTime.Parse("10-23-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 1230M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "" && x.LastName == "RO142107" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Julienne" && x.LastName == "Del-Isen");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("09-17-2016"), Departure = DateTime.Parse("10-24-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 1083.58M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Shinya" && x.LastName == "Takizawa" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Guilherma" && x.LastName == "Irma Caringal");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("10-23-2016"), Departure = DateTime.Parse("12-03-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 820M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Shinya" && x.LastName == "Takizawa" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Guilherma" && x.LastName == "Irma Caringal");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("09-11-2016"), Departure = DateTime.Parse("10-23-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 1230M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Shinto" && x.LastName == "Yamaniha" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Josefa" && x.LastName == "Secretaria");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("10-23-2016"), Departure = DateTime.Parse("12-03-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 820M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Yu-Wei" && x.LastName == "Huang" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Filipinas" && x.LastName == "Caliwag");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("10-16-2016"), Departure = DateTime.Parse("11-13-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 820M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Chin-Tzu" && x.LastName == "Chen" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Romilda" && x.LastName == "Adan");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("10-16-2016"), Departure = DateTime.Parse("12-16-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 1200M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Tatiana" && x.LastName == "Mara Cintra" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Romilda" && x.LastName == "Adan");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("11-05-2016"), Departure = DateTime.Parse("12-03-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 0M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "" && x.LastName == "RO160603" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Romilda" && x.LastName == "Adan");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("10-01-2016"), Departure = DateTime.Parse("10-17-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 175.74M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "" && x.LastName == "RO160603" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Romilda" && x.LastName == "Adan");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("10-01-2016"), Departure = DateTime.Parse("10-29-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 820M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "" && x.LastName == "RO151134" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Romilda" && x.LastName == "Adan");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("11-15-2016"), Departure = DateTime.Parse("12-12-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 760M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "" && x.LastName == "RO150927" && x.Gender == true && x.SiteLocation == kgicVancouver);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Romilda" && x.LastName == "Adan");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("07-31-2016"), Departure = DateTime.Parse("09-01-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 937.16M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Wei-Ting" && x.LastName == "Wu" && x.Gender == true && x.SiteLocation == kgicVictoria);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Pam" && x.LastName == "Virk");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("10-28-2016"), Departure = DateTime.Parse("10-28-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 50M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "Wei-Ting" && x.LastName == "Wu" && x.Gender == true && x.SiteLocation == kgicVictoria);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Pam" && x.LastName == "Virk");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("10-28-2016"), Departure = DateTime.Parse("11-25-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 820M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            student = _context.Students.FirstOrDefault(x => x.FirstName == "" && x.LastName == "VI160125" && x.Gender == true && x.SiteLocation == kgicVictoria);
            if (student != null)
            {
                homestay = _context.Homestays.FirstOrDefault(x => x.FirstName == "Pam" && x.LastName == "Virk");
                if (homestay != null)
                {
                    homestayStudent = new HomestayStudent() { Arrival = DateTime.Parse("07-16-2016"), Departure = DateTime.Parse("08-12-2016"), DueDate = DateTime.Parse("01-01-1900"), PaidAmount = 0M, Amount = 870M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay };
                    _context.HomestayStudents.Add(homestayStudent);
                }
            }

            _context.SaveChanges();
        }
    }
}
