using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Keepr.Models;

namespace Keepr.Repositories
{
  public class KeepsRepository
  {
    private readonly IDbConnection _db;
    public KeepsRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Keep> Get()
    {
      string sql = "SELECT * FROM keeps";
      return _db.Query<Keep>(sql);
    }

    public Keep Get(int id)
    {
      string sql = "SELECT * FROM keeps";
      return _db.QueryFirstOrDefault<Keep>(sql);
    }

    public Keep Get(string name)
    {
      string sql = "SELECT * FROM keeps WHERE name = @name";
      return _db.QueryFirstOrDefault<Keep>(sql, new { name });
    }

    public int Create(Keep newKeep)
    {
      string sql = @"
      INSERT INTO keeps
      (name, description, img)
      VALUES
      (@Name, @Description, @img);
      SELECT LAST_INSERT_ID();";
      return _db.ExecuteScalar<int>(sql, newKeep);
    }

    public void Edit(Keep keep)
    {
      string sql = @"
      UPDATE keeps
      SET
        name = @Name,
        description = @Description, 
        img = @img,
        WHERE id = @Id";
      _db.Execute(sql, keep);
    }

    public void Delete(int id)
    {
      string sql = "DELETE FROM keeps WHERE id = @id";
      _db.Execute(sql, new { id });
    }

    public IEnumerable<Keep> GetKeepsByVaultId(int id)
    {
      string sql = "SELECT * FROM keeps WHERE keepId = @id";
      return _db.Query<Keep>(sql, new { id });
    }

  }
}