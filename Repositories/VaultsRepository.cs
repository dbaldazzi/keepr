using System;
using System.Data;
using keepr.Services;
using Keepr.models;
using System.Collections.Generic;
using Dapper;

namespace keepr.Repositories 
{
    public class VaultsRepository
    {
    private readonly IDbConnection _db; 

    public VaultsRepository(IDbConnection db) 
    {
      _db = db; 
    }

    internal IEnumerable<Vault> Get()
    {
      string sql = "SELECT * FROM vaults";
      return _db.Query<Vault>(sql);
    }

    public Vault Get(int id)
    {
      string sql = "SELECT * FROM vaults WHERE id = @id";
      return _db.QueryFirstOrDefault<Vault>(sql, new { id });
    }
      public Vault Get(string name)
    {
      string sql = "SELECT * FROM vaults WHERE name = @name";
      return _db.QueryFirstOrDefault<Vault>(sql, new { name });
    }
    public int Create(Vault newVault)
    {
      string sql = @"
      INSERT INTO vaults
      (name, description, userid) 
      VALUES 
      (@Name, @Description, @Userid);
      SELECT LAST_INSET_ID();";
      return _db.ExecuteScalar<int>(sql, newVault);
    }

  
  }
}