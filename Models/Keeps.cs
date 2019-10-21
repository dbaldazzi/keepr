using Keepr.interfaces;
using System;
using System.Collections.Generic;

namespace Keepr.Models
{

  public class Keep : IKeeps
  {
    // public int id { get ; set ; }
    public int Id { get; set; }

    public string name { get ; set ; }
    public string description { get ; set ; }
    // public string userid { get ; set ; }
    public int views { get ; set ; }
    public int shares { get ; set ; }
    public int keeps { get ; set ; }
    public object Img { get; set; }
    public int VaultId { get; set; }

    // public string userid { get; set; }
    string IKeeps.Img { get; set; }
  }
}