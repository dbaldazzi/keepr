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
    public IEnumerable<Keep> Get(int vaultId, string newData)
    {
      string sql = @"SELECT * FROM vaults v INNER JOIN keeps K on K.id = VaultKeeps.keepId WHERE (VaultId = @VaultId AND vk.userId = @userId)";
      return _db.Query<Keep>(sql, new { vaultId });
    }
    // public VaultKeeps Get(VaultKeeps vaultId)
    // {
    //   string sql = "SELECT * FROM vaultkeeps where vaultId = @vaultId";
    //   return _db.QueryFirstOrDefault<VaultKeeps>(sql, new { vaultId });
    // }
// public VaultKeeps GetVaultKeeps(VaultKeeps VaultId)
//     {
//       string sql = "SELECT * FROM vaultKeeps WHERE vaultId = @vaultId";
//       return _db.QueryFirstOrDefault<VaultKeeps>(sql, new {VaultId});
//     }
    public int Create(VaultKeeps newVaultKeeps)
    {
      string sql = @"
      INSERT INTO vaultKeeps
      (vaultId, keepId, userId)
      VALUES
      (@VaultId, @KeepId, @UserId);
      SELECT LAST_INSERT_ID();";
      return _db.ExecuteScalar<int>(sql, newVaultKeeps);
    }

    

    public void Delete(int id)
    {
      string sql = "DELETE FROM vaultKeeps WHERE id = @id";
      _db.Execute(sql, new { id });
    }

    

    public void Edit(VaultKeeps vaultKeeps)
    {
      string sql = @"
      UPDATE vaultKeeps
      SET 
      vaultId = @vaultId,
      keepId = @keepId
      WHERE Id = @id";
      _db.Execute(sql, vaultKeeps);
    }

   
  
  }
}
