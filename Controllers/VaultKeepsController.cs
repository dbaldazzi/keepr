using System;
using System.Collections.Generic;
using Keepr.Models;
using Keepr.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Keepr.Controllers
{
  
  [ApiController]
  [Route("api/[controller]")]
   
  public class VaultKeepsController : ControllerBase
  {
    
    private readonly VaultKeepsService _vks;

    public VaultKeepsController(VaultKeepsService vks)
    {
      _vks = vks;
    }
    [HttpGet]
    public ActionResult<VaultKeeps> Get()
    {
      try
      {
        return Ok(_vks.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult <IEnumerable<Keep>> Get(int id, Keep newData) 
{
  try 
  {
        newData.UserId = HttpContext.User.FindFirstValue("Id");
        return Ok(_vks.Get(newData)); 
      }
      catch (Exception e) 
      {
        return BadRequest(e.Message); 
      }
}
// [HttpGet("{id}")]
// public ActionResult<IEnumerable<VaultKeeps>> Get(VaultKeeps VaultId) 
// {
//   try 
//   {
//         return Ok(_vks.Get(VaultId));
//       }
//       catch (Exception e)
//       {
//         return BadRequest(e.Message); 
//       }
// }
    [HttpPost]
    public ActionResult<VaultKeeps> Create([FromBody] VaultKeeps newVaultKeeps)
    
    {
      try
      {
        newVaultKeeps.UserId = HttpContext.User.FindFirstValue("Id");
        return Ok(_vks.Create(newVaultKeeps));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // [HttpPut("{id}")]
    // public ActionResult<VaultKeeps> Edit([FromBody] VaultKeeps newVaultKeeps, int id)
    // {
    //   try 
    //   {
    //     newVaultKeeps.UserId = HttpContext.User.FindFirstValue("Id");
    //     newVaultKeeps.Id = id; 
    //     return Ok(_vks.Edit(newVaultKeeps)); 
    //   }
    //   catch (Exception e) 
    //   {
    //     return BadRequest(e.Message); 
    //   }
    // }

    // [HttpDelete("{id}")]
    // public ActionResult<string> Delete(int id, VaultKeeps newVaultKeeps)
    // {
    //   try
    //   {
    //     newVaultKeeps.UserId = HttpContext.User.FindFirstValue("Id");
    //     newVaultKeeps.VaultId = HttpContext.User.FindFirstValue("VaultId"); 
    //     newVaultKeeps.KeepId = HttpContext.User.FindFirstValue("KeepId");
    //     return Ok(_vks.Delete(id));
    //   }
    //   catch (Exception e)
    //   {
    //     return BadRequest(e.Message);
    //   }
    // }
  }
}