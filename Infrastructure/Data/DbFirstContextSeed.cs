using System.Globalization;
using System.Reflection;
using Core.Entities;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.Extensions.Logging;
namespace Infrastructure.Data;

public class DbFirstContextSeed
{
    public static async Task SeedAsync(DbFirstContext context, ILoggerFactory loggerFactory)
    {
        try
        {
            // * Inicio de las insersiones en la Database
            var ruta = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            if (!context.Drivers.Any())
            {
                using (var reader = new StreamReader(ruta + @"/Data/Csv/Driver.csv"))
                {
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var list = csv.GetRecords<Driver>();
                        context.Drivers.AddRange(list);
                        await context.SaveChangesAsync();
                    }
                }
            }

            if (!context.Teams.Any())
            {
                using (var reader = new StreamReader(ruta + @"/Data/Csv/Team.csv"))
                {
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var list = csv.GetRecords<Team>();
                        context.Teams.AddRange(list);
                        await context.SaveChangesAsync();
                    }
                }
            }

            if (!context.TeamDrivers.Any())
            {
                using (var reader = new StreamReader(ruta + @"\Data\Csv\TeamDriver.csv"))
                {
                    using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        HeaderValidated = null,
                        MissingFieldFound = null
                    }))
                    {
                        var list = csv.GetRecords<TeamDriver>();
                        List<TeamDriver> entidad = new List<TeamDriver>();
                        foreach (var item in list)
                        {
                            entidad.Add(new TeamDriver
                            {
                                IdTeam = item.IdTeam,
                                IdDriver = item.IdDriver
                            });
                        }
                        context.TeamDrivers.AddRange(entidad);
                        await context.SaveChangesAsync();
                    }
                }
            }
            // * Fin de las insersiones en la Database
        }
        catch (Exception ex)
        {
            var logger = loggerFactory.CreateLogger<DbFirstContext>();
            logger.LogError(ex.Message);
        }
    }
}