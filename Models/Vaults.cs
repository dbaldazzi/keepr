using System.Collections.Generic;
using System;
using Keepr.interfaces;

namespace Keepr.models
{

  public class Vault : IVaults
  {

    public int Id { get; set; }
    // public int id { get; set; }
    public string name { get ; set ; }
    public string description { get ; set ; }
    public string userId { get ; set ; }
  }
}