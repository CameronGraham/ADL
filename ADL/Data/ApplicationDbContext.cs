using Microsoft.EntityFrameworkCore;
using ADL.Data;
using System;

namespace ADL.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<EngineerRequest> Requests { get; set; }

        //seed data for unavailable dates
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EngineerRequest>().HasData(
                new EngineerRequest()
                {
                    Id = 1,
                    FirstName = "Joe",
                    LastName = "Bloggs",
                    EmailAddress = "joe.bloggs@email.com",
                    ContactNumber = "12345678910",
                    Address = "123 Test Way",
                    Town = "TownName",
                    Postcode = "postcode",
                    AppointmentDate = DateTime.Parse("09/05/2022 00:00:00"),
                    AppointmentTime = "11:00 - 13:00",
                    VehicleRegistation = "1234567",
                    JobCategory = "breakdown",
                    Comments = "The bus is broken"
                },
                new EngineerRequest()
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    EmailAddress = "janedoe@email.com",
                    ContactNumber = "12345678910",
                    Address = "124 Test Way",
                    Town = "TownName",
                    Postcode = "postcode",
                    AppointmentDate = DateTime.Parse("10/05/2022 00:00:00"),
                    AppointmentTime = "09:00 - 11:00",
                    VehicleRegistation = "1234567",
                    JobCategory = "warranty",
                    Comments = "Engine making noise"
                },
                    new EngineerRequest()
                    {
                        Id = 3,
                        FirstName = "Joe",
                        LastName = "Bloggs",
                        EmailAddress = "joe.bloggs@email.com",
                        ContactNumber = "12345678910",
                        Address = "125 Test Way",
                        Town = "TownName",
                        Postcode = "postcode",
                        AppointmentDate = DateTime.Parse("12/05/2022 00:00:00"),
                        AppointmentTime = "09:00 - 11:00",
                        VehicleRegistation = "1234567",
                        JobCategory = "breakdown",
                        Comments = "The bus is broken"
                    }
            );
        }
    }
}
