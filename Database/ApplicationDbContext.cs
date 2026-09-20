using System.Data.Entity; // This is the main namespace for EF6 DbContext
using AirlineManagementApp.Models; // To access your Passenger and Flight classes

namespace AirlineManagementApp
{
    public class ApplicationDbContext : DbContext
    {
        static ApplicationDbContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>());
        }

        // Constructor that calls the base DbContext constructor.
        // "name=AirlineDbConnection" tells EF6 to look for a connection string
        // named "AirlineDbConnection" in your App.config file.
        public ApplicationDbContext() : base("name=AirlineDbConnection")
        {
            // Optional: Disable lazy loading globally if you prefer explicit loading.
            // this.Configuration.LazyLoadingEnabled = false;

            // Optional: Database initializer (can be useful for development)
            // For example, to create the database if it doesn't exist:
            // Database.SetInitializer<ApplicationDbContext>(new CreateDatabaseIfNotExists<ApplicationDbContext>());
            // Or to drop and recreate the database if the model changes (USE WITH CAUTION IN PRODUCTION):
            // Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
        }

        // DbSet properties: These represent the tables in your database.
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Flight> Flights { get; set; }

        // Optional: If you need more complex model configurations (e.g., fluent API for relationships
        // that can't be expressed well with data annotations), you can override OnModelCreating.
        // For our current simple model, Data Annotations are likely sufficient.
        // protected override void OnModelCreating(DbModelBuilder modelBuilder)
        // {
        //    // Example: If you wanted to configure something using Fluent API
        //    // modelBuilder.Entity<Passenger>()
        //    //    .Property(p => p.Name)
        //    //    .IsRequired();
        //
        //    base.OnModelCreating(modelBuilder);
        // }
    }
}
