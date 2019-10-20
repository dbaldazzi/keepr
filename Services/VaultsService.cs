using keepr.Repositories;
using Keepr.models;
using Keepr.Repositories;
using System; 
using System.Collections.Generic; 

namespace keepr.Services
{
  public class VaultsService
  {
    private readonly VaultsRepository _repo;
    private readonly KeepsRepository _kRepo;

    public VaultsService(VaultsRepository repository, KeepsRepository kRepo)
    {
      _repo = repository;
      _kRepo = kRepo;
    }
    public IEnumerable<Vault> Get()
    {
      return _repo.Get();
    }
    public Vault Get(int id)
    {
      Vault exists = _repo.Get(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      return exists;
    }
    public Vault Create(Vault newVault)
    {
      Vault vault = _repo.Get(newVault.name);
      if (vault != null) { throw new Exception("Vault already existis"); }
      int id = _repo.Create(newVault);
      newVault.Id = id;
      return newVault;
    }
    public Vault Edit(Vault editVault)
    { 
    if (Vault == null) {throw new Exception("Invalid Id"); }
    vault.Name == editVault.Name; 
}
}
}


