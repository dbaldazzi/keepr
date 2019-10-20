using keepr.Services;
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
      
    }
  }
}