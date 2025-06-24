using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;


namespace JuliePro.Models.Data

{
    public static class ModelBuilderDataGenerator
    {

        public static void GenerateData(this ModelBuilder builder)
        {
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 1, Name = "Perte de poids" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 2, Name = "Course" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 3, Name = "Halthérophilie" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 4, Name = "Réhabilitation" });

            builder.Entity<Trainer>().HasData(new Trainer() { Id = 1, FirstName = "Chrystal", LastName = "Lapierre", Email = "Chrystal.lapierre@juliepro.ca", SpecialityId = 1, Photo = "Chrystal.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 2, FirstName = "Félix", LastName = "Trudeau", Email = "Felix.trudeau@juliePro.ca", SpecialityId = 2, Photo = "Felix.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 3, FirstName = "François", LastName = "Saint-John", Email = "Frank.StJohn@juliepro.ca", SpecialityId = 1, Photo = "Francois.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 4, FirstName = "Jean-Claude", LastName = "Bastien", Email = "JC.Bastien@juliepro.ca", SpecialityId = 4, Photo = "JeanClaude.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 5, FirstName = "Jin Lee", LastName = "Godette", Email = "JinLee.godette@juliepro.ca", SpecialityId = 3, Photo = "Jin Lee.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 6, FirstName = "Karine", LastName = "Lachance", Email = "Karine.Lachance@juliepro.ca", SpecialityId = 2, Photo = "Karine.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 7, FirstName = "Ramone", LastName = "Esteban", Email = "Ramone.Esteban@juliepro.ca", SpecialityId = 3, Photo = "Ramone.png" });

            builder.Entity<Customer>().HasData(
            new Customer { CustomerId = 1, FirstName = "Alice", LastName = "Smith", Email = "alice@juliepro.ca", BirthDate = new DateTime(1990, 1, 1), StartWeight = 150 },
            new Customer { CustomerId = 2, FirstName = "Bob", LastName = "Brown", Email = "bob@juliepro.ca", BirthDate = new DateTime(1985, 2, 2), StartWeight = 180 },
            new Customer { CustomerId = 3, FirstName = "Carol", LastName = "Johnson", Email = "carol@juliepro.ca", BirthDate = new DateTime(1992, 3, 3), StartWeight = 140 },
            new Customer { CustomerId = 4, FirstName = "David", LastName = "Davis", Email = "david@juliepro.ca", BirthDate = new DateTime(1988, 4, 4), StartWeight = 200 }
            );


            //CHATGPT
            builder.Entity<Objective>().HasData(
                // Client 1 - Alice - 1 courant, 3 complétés
                new Objective { ObjectiveId = 1, Name = "Perte 5kg", LostWeightKg = 5, DistanceKm = 0, AchievedDate = null, CustomerId = 1 },
                new Objective { ObjectiveId = 2, Name = "Course 5km", LostWeightKg = 0, DistanceKm = 5, AchievedDate = DateTime.Now.AddMonths(-3), CustomerId = 1 },
                new Objective { ObjectiveId = 3, Name = "Perte 3kg", LostWeightKg = 3, DistanceKm = 0, AchievedDate = DateTime.Now.AddMonths(-2), CustomerId = 1 },
                new Objective { ObjectiveId = 4, Name = "Course 10km", LostWeightKg = 0, DistanceKm = 10, AchievedDate = DateTime.Now.AddMonths(-1), CustomerId = 1 },

                // Client 2 - Bob - 2 courants
                new Objective { ObjectiveId = 5, Name = "Perte 7kg", LostWeightKg = 7, DistanceKm = 0, AchievedDate = null, CustomerId = 2 },
                new Objective { ObjectiveId = 6, Name = "Course 8km", LostWeightKg = 0, DistanceKm = 8, AchievedDate = null, CustomerId = 2 },

                // Client 3 - Carol - 2 complétés
                new Objective { ObjectiveId = 7, Name = "Course 6km", LostWeightKg = 0, DistanceKm = 6, AchievedDate = DateTime.Now.AddMonths(-4), CustomerId = 3 },
                new Objective { ObjectiveId = 8, Name = "Perte 4kg", LostWeightKg = 4, DistanceKm = 0, AchievedDate = DateTime.Now.AddMonths(-3), CustomerId = 3 },

                // Client 4 - David - 1 courant, 1 complété
                new Objective { ObjectiveId = 9, Name = "Course 12km", LostWeightKg = 0, DistanceKm = 12, AchievedDate = null, CustomerId = 4 },
                new Objective { ObjectiveId = 10, Name = "Perte 6kg", LostWeightKg = 6, DistanceKm = 0, AchievedDate = DateTime.Now.AddMonths(-2), CustomerId = 4 }
            );

        }
    }
}
