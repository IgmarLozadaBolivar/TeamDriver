namespace Core.Interfaces;

public interface IUnitOfWork
{
    IDriver Drivers { get; }
    ITeam Teams { get; }
    ITeamDriver TeamDrivers { get; }

    Task<int> SaveAsync();
}