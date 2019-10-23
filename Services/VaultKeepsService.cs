using System;
using System.Collections.Generic;
using Keepr.Models;
using Keepr.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


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
    public VaultKeeps Get(int id)
    {
      VaultKeeps exists = _repo.Get(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      return exists;
    } 
    // public VaultKeeps GetVaultKeeps(string id)
    // {
    //   VaultKeeps exists = _repo.Get(id);
    //   if (exists == null) { throw new Exception("Invalid Id"); }
    //   return exists;
    // }
    public VaultKeeps Create(VaultKeeps newData)
    {
      int id = _repo.Create(newData);
      newData.Id = id;
      return newData;
    }
    public VaultKeeps Get(VaultKeeps vaultId)
    {
      VaultKeeps exists = _repo.Get(vaultId);
      if (exists == null) { throw new Exception("Invalid Id"); }
      return exists; 
    }
    public VaultKeeps Edit(VaultKeeps newData)
    {
      VaultKeeps vaultKeeps = _repo.Get(newData.Id);
      if (vaultKeeps == null) { throw new Exception("Invalid Id"); }
      vaultKeeps.VaultId = newData.VaultId;
      vaultKeeps.KeepId = newData.KeepId;
      _repo.Edit(vaultKeeps);
      return vaultKeeps;
    }

    

    public string Delete(int id)
    {
      VaultKeeps vaultKeeps = _repo.Get(id);
      if (vaultKeeps == null) { throw new Exception("Invalid Id"); }
      _repo.Delete(id);
      return "Successfully Deleted";
    }

    // public object Delete(VaultKeeps newVaultKeeps)
    // {
    //   VaultKeeps vaultKeeps = _repo.Get(id);
    //   if (vaultKeeps == null) { throw new Exception("Invalid Id"); }
    //   _repo.Delete(id);
    //   return "succefully Deleted"; 
    // }
  }
}
