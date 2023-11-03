using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repository;

public class TeamDriverRepo : Generic<TeamDriver>, ITeamDriver
{
    protected readonly DbFirstContext _context;

    public TeamDriverRepo(DbFirstContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<TeamDriver>> GetAllAsync()
    {
        return await _context.TeamDrivers
            .Include(p => p.Team)
            .Include(p => p.Driver)
            .ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<TeamDriver> registros)> GetAllAsync(int pageIndex, int pageSize, string search)
    {
        var query = _context.TeamDrivers as IQueryable<TeamDriver>;

        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.IdTeam.ToString().ToLower().Contains(search));
            query = query.Where(p => p.IdDriver.ToString().ToLower().Contains(search));
        }

        var totalRegistros = await query.CountAsync();
        var registros = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalRegistros, registros);
    }
}