

namespace Application.Common.Interfaces.Repositories;

public interface IContestantRepository: IRepository<Contestant>
{
    Task<Contestant> GetAllContestantInformation(int id);
}
