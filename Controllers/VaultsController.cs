using keepr.Services;
using Keepr.models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace keepr.Controller
{
    [ApiController]
    [Route("api/[controller]")]

    public class VaultsController : ControllerBase
    {
    private readonly VaultsService _vs; 
    public VaultsController(VaultsService vs)
    {
      _vs = vs;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Vault>> Get()
    {
      try 
      {
        return Ok(_vs.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message)
      }
      
    }
  }
}