using System;
using System.Collections.Generic;
using System.Security.Claims;
using keepr.Services;
using Keepr.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Keepr.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class KeepsController : ControllerBase
  {
    private readonly keepsService _ks;
    public KeepsController(keepsService ks)
    {
      _ks = ks;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Keep>> Get()
    {
      try
      {
        return Ok(_ks.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Keep> Get(int id)
    {
      try
      {
        return Ok(_ks.Get(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // [HttpGet]
    // public ActionResult<Keep> Get(Keep newKeep) 
    // {
    //   try
    //   {
    //       newKeep.UserId = HttpContext.User.FindFirstValue("id"); 
    //     return Ok(_ks.Get(newKeep));
    //   }
    //   catch (Exception e) 
    //   {
    //     return BadRequest(e.Message); 
    //   }
    // }

    [HttpGet("{id}/keep")]
    public ActionResult<IEnumerable<Keep>> GetKeep(int id)
    {
      try
      {
        return Ok(_ks.GetKeep(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [Authorize]
    [HttpPost]

    public ActionResult<Keep> Create([FromBody]Keep newkeep)
    {
      try
      {
        newkeep.UserId = HttpContext.User.FindFirstValue("Id");
        return Ok(_ks.Create(newkeep));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [Authorize]
    [HttpPut("{id}")]

    public ActionResult<Keep> Edit([FromBody] Keep editKeep, int id)
    {
      try
      {
        editKeep.Id = id;
        return Ok(_ks.Edit(editKeep));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [Authorize]
    [HttpDelete("{id}")]

    public ActionResult<string> Delete(int id)
    {
      try
      {
        return Ok(_ks.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}

