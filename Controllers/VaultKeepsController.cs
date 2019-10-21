using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Keepr.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
    public class VaultKeepsController : ControllerBase
    {
private readonly VaultKeepsService _vks; 

public VaultKeepsController(VaultsKeepsService vks)
{
      _vks = vks;
    }
  }
}