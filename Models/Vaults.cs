using System.Collections.Generic;
using System;
using Keepr.interfaces;

namespace Keepr.models
{

  public class Vault : IVaults
  {
    public int id { get ; set ; }
    public int Id { get; internal set; }
    public string name { get ; set ; }
    public string description { get ; set ; }
    public string userId { get ; set ; }
  }
}