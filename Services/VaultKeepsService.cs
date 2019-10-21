using System;
using System.Collections.Generic;
using Keepr.Models;
using Keepr.Repositories;

namespace Keepr.Services
{

  public class VaultKeepsService
  {
    private readonly VaultKeepsRepository _repo;

    private readonly KeepsRepository _keepsRepo;
    public VaultKeepsService(VaultKeepsRepository repo, KeepsRepository KeepsRepo)
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
