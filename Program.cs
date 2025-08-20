using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    //.SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddUserSecrets<Program>();
   //last one win...

    IConfiguration configuration = builder.Build();

    Console.WriteLine("Reading Logging values...");
    var appSettings = configuration.GetSection("Logging");
     Console.WriteLine($"AppSettings: {appSettings["LogLevel:Default"]}");

     Console.WriteLine(configuration.GetValue<int>("StarterCountValue"));

Console.WriteLine(configuration.GetValue<string>("User:Name"));

Console.WriteLine("my script: " + configuration.GetValue<string>("MySecretKey"));

Console.ReadLine();