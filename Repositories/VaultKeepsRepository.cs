using System; 
using System.Collections.Generic;
using System.Data;
using Dapper;
using Keepr.Models;

namespace Keepr.Repositories
{
    public class VaultKeepsRepository
    {
      
      private readonly IDbConnection _db; 
      public VaultKeepsRepository(IDbConnection db) 
      {
        _db = db; 
      }

    public IEnumerable<VaultKeeps> Get()
    {
      string sql = "SELECT * FROM vaultKeeps";
      return _db.Query<VaultKeeps>(sql); 
    }

    public int Create(VaultKeeps newVaultKeeps)
    {
      string sql = @"
      INSERT INTO vaultKeeps
      (vaultId, keepId)
      VALUES
      (@VaultId, @KeepId);
      SELECT LAST_INSERT_ID();";
      return _db.ExecuteScalar<int>(sql, newVaultKeeps); 
    }

    public void Delete(int id)
    {
      string sql = "DELETE FROM vaultKeeps WHERE id = @id";
      _db.Execute(sql, new { id }); 
    }

    public VaultKeeps Get(int id)
    {
      string sql = "SELECT * FROM vaultKeeps WHERE id = @id";
      return _db.QueryFirstOrDefault<VaultKeeps>(sql, new { id }); 
    }
  }
    }
