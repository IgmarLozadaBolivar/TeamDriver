using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;
namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly DbFirstContext context;
    private DriverRepo _drivers;
    private TeamRepo _teams;
    private TeamDriverRepo _teamDrivers;

    public UnitOfWork(DbFirstContext _context)
    {
        context = _context;
    }


    public IDriver Drivers
    {
        get
        {
            if (_drivers == null)
            {
                _drivers = new DriverRepo(context);
            }
            return _drivers;
        }
    }

    public ITeam Teams
    {
        get
        {
            if (_teams == null)
            {
                _teams = new TeamRepo(context);
            }
            return _teams;
        }
    }

    public ITeamDriver TeamDrivers
    {
        get
        {
            if (_teamDrivers == null)
            {
                _teamDrivers = new TeamDriverRepo(context);
            }
            return _teamDrivers;
        }
    }

    public void Dispose()
    {
        context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await context.SaveChangesAsync();
    }
}