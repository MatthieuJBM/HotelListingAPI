1. Two Libraries: 
    - Microsoft.EntityFrameworkCore.Tools
    - MySql.EntityFrameworkCore
2. We need a class that inherits from DbContext.
3. We have to pass the options.
4. We have to define our entities as DbSet<EntityName>.
5. We have an OnModelCreating method that we can override to do other things to let it know when you are creating the database, also do these things right.
6. [ForeignKey(nameof(CountryId))]
7. {
   "ConnectionStrings": {
   "HotelListingDbConnectionString": "Server=localhost;Database=HotelListingAPIDb;User=username;Password=password;Port=3306"
   },
8. // Add services to the container.
   var connectionString = builder.Configuration.GetConnectionString("HotelListingDbConnectionString");
   builder.Services.AddDbContext<HotelListingDbContext>(options =>
   {
   options.UseMySQL(connectionString);
   });
   builder.Services.AddControllers()
9. 