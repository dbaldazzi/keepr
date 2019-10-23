using System;
using System.Collections;
using System.Collections.Generic;
using Keepr.Models;
using Keepr.Repositories;

namespace keepr.Services


{
  public class keepsService
  {
    private readonly KeepsRepository _repo;

    public keepsService(KeepsRepository repo)
    {
      _repo = repo;
    }

    public IEnumerable<Keep> Get()
    {
      return _repo.Get();
    }
    public Keep Get(int id)
    {
      Keep exists = _repo.Get(id);
      if (exists == null) { throw new Exception("invalid Id"); }
      return exists; 
    }

    public Keep Create(Keep newkeep)
    {

      int id = _repo.Create(newkeep);
      newkeep.Id = id;
      return newkeep;
    }

    public Keep Edit(Keep editKeep)
    {
      Keep keep = _repo.Get(editKeep.Id);
      
      if (keep == null) { throw new Exception("Invalid Id"); }
      keep.name = editKeep.name;
      keep.description = editKeep.description;
      keep.Img = editKeep.Img;
      _repo.Edit(keep);
      return keep;
    }

    public Keep Get(string id)
    {
      Keep exists = _repo.Get(id);
      if (exists == null) { throw new Exception("invalid Id"); }
      return exists; 
    }

    public string Delete(int id)
    {
      Keep exists = _repo.Get(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      _repo.Delete(id);
      return "Deleted";

    }
  }
}