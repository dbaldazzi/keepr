using System;
using System.Collections;
using System.Data;

namespace Keepr.Repositories
{
    public class KeepsRepository 
    {
    private readonly IDbConnection _db;
    public KeepsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal System.Collections.Generic.IEnumerable<Keep> Get(int id)
    {
      throw new NotImplementedException();
    }

    internal System.Collections.Generic.IEnumerable<Keep> Get()
    {
      throw new NotImplementedException();
    }

    internal IEnumerable GetKeep(int v, int id)
    {
      throw new NotImplementedException();
    }

    internal int Create(object newKeep)
    {
      throw new NotImplementedException();
    }

    internal Keep Get(object name)
    {
      throw new NotImplementedException();
    }

    internal void Edit(Keep keep)
    {
      throw new NotImplementedException();
    }

    internal void Delete(int id)
    {
      throw new NotImplementedException();
    }
  }
}