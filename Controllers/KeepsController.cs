using System;
using System.Collections.Generic;
using keepr.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Keepr.Controllers
{
  [ApiController]
  [Route("api/[contgroller]")]

  public class KeepsController : ControllerBase
  {
    private readonly keepsService _ks;
    public KeepsController(keepsService ks)
    {
      _ks = ks;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Keeps>> Get()
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
    [HttpPost("{id}")]

    public ActionResult<Keep> Create([FromBody]Keep newkeep)
    {
      try
      {
        return Ok(_ks.Create(newkeep));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [Authorize]
    [HttpPut("{id}")]

    public ActionResult<Keep> Edit([FromBody] Keep editKeep)
    {
      try 
      {
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

