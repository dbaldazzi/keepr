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
      Vault vault = _repo.Get(editVault.Id); 
      if (vault == null) {throw new Exception("Invalid Id"); }
    vault.name = editVault.name;
      vault.description = editVault.description;
      _repo.edit(vault);
      return vault; 
    }

    internal object GetVault(int id)
    {
      throw new NotImplementedException();
    }

    public string Delete(int id) 
    {
      Vault exists = _repo.Get(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      _repo.Delete(id);
      return "Deleted"; 
    }
}
}


