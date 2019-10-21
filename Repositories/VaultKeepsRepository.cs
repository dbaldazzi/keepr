using System; 
using System.Collections.Generic;
using System.Data;

namespace Keepr.Repositories
{
    public class VaultsKeepsRepository
    {
      
      private readonly IDbConnection _db; 
      public VaultsKeepsRepository(IDbConnection db) 
      {
        _db = db; 
      }

    internal IEnumerable<VaultKeeps> Get()
    {
      throw new NotImplementedException();
    }

    internal int Create(VaultKeeps newVaultKeeps)
    {
      throw new NotImplementedException();
    }
  }
    }
