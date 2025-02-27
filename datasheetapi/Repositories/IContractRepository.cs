namespace datasheetapi.Repositories;

public interface IContractRepository
{
    Task<Contract?> GetContract(Guid id);
    Task<List<Contract>> GetContracts();
    Task<List<Contract>> GetContractForContractor(Guid contractorId);
    Task<List<Contract>> GetContractForProject(Guid projectId);
}
