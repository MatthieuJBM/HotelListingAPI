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
9. Scaffolding functionality to allow our API to interact with our data table that is called countries through our model called country.
10. Right click on Controllers folder -> Add -> Scaffolded Item... -> API Controller with Actions, using Entity Framework -> Name for example CountriesController
11. Our scaffolded code features some keywords that are defined below for full understanding.

    Task - A task in C# is used to implement Task-based Asynchronous Programming. The Task object is typically executed asynchronously on a thread pool thread rather than synchronously on the main thread of the application.

    async - Signals to the compiler that this method contains an await statement; it contains asynchronous operations.

    await - The await keyword provides a non-blocking way to start a task, then continue execution when that task completes.

    ActionResult - An action is capable of returning a specific data type (see WeatherForecastController action).  When multiple return types are possible, it's common to return ActionResult, IActionResult or ActionResult<T>, where T represents the data type to be returned.

USING AUTOMAPPER
1. Automapper maps objects from one type to another.
2. Add AutoMapper from NuGets.
3. Create a file MapperConfig that extends "Profile" and write the following in the constructor: CreateMap<Country, CreateCountryDto>().ReverseMap();
4. Add the following line in Program.cs: builder.Services.AddAutoMapper(typeof(MapperConfig));
5. We inject the MapperConfig into our CountriesController:
   private readonly IMapper _mapper;
   public CountriesController(HotelListingDbContext context, IMapper mapper)
     {
         _context = context;
         this._mapper = mapper;
     }

REPOSITORIES
1. Contract represents the abstraction of a class and the repository will represent the implementation of that class.
2. Interface is like a contract, it is enforcing what should happen. Think of a contract as a paperwork. When you sign up a contract you are stating that you agree to do certain things right.
3. Now that we have our specific repository is created we need to register it in our Program.cs
4. 