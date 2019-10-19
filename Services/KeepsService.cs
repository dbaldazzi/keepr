using System;
using System.Collections;
using System.Collections.Generic;
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
    }
    // public Keep GetKeeps(int id)
    // {
    //   return _repo.GetKeeps(int id);

    // }

   public Keep Create(Keep newkeeps)
    {
      Keep keep = _repo.Get(newkeeps.Name);
      if (keep != null) { throw new Exception("Keep already exists"); }
      int id = _repo.Create(newkeeps);
      newkeeps.Id = id;
      return new Keep; 
    }

    public Keep Edit(Keep editKeep)
    {
      Keep keep = _repo.Get(editKeep.Id);
      if (keep == null) { throw new Exception("Invalid Id"); }
      keep.Name = editKeep.Name;
      keep.Description = editKeep.Description;
      keep.Img = editKeep.Img;
      keep.IsPrivate = editKeep.IsPrivate;
      _repo.Edit(keep);
      return keep;
    }

    internal object GetKeep(int id)
    {
      throw new NotImplementedException();
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