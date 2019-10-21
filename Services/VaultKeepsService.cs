using System;
using System.Collections.Generic;
using keepr.Repositories;
using Keepr.Repositories;

namespace Keepr.VaultKeepsService
{
  public class VaultKeepsService
  {
    private readonly VaultsKeepsRepository _repo;

    private readonly KeepsRepository _keepsRepo;
    public VaultKeepsService(VaultsKeepsRepository repo, KeepsRepository KeepsRepo)
    {
      _keepsRepo = KeepsRepo;
      _repo = repo;
    }

    public IEnumerable<VaultKeeps> Get()
    {
      return _repo.Get();
    }
    public VaultKeeps Create(VaultKeeps newVaultKeeps)
    {
      int id = _repo.Create(newVaultKeeps);
      newVaultKeeps.Id = id;
      return newVaultKeeps;
    }
    public string Delete(int id)
    {
      VaultKeeps vaultKeeps = _repo.Get(id);
      if (vaultKeeps == null) { throw new Exception("Invalid Id"); }
      _repo.Delete(id);
      return "Successfully Deleted";
    }
  }
}
