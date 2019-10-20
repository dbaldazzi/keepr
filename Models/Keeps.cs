using Keepr.interfaces;
using System;
using System.Collections.Generic;

namespace Keepr.Models
{

  public class Keep : IKeeps
  {
    public int id { get ; set ; }
    public int Id { get; internal set; }
    public string name { get ; set ; }
    public string description { get ; set ; }
    public object Description { get; internal set; }
    public string userid { get ; set ; }
    public int views { get ; set ; }
    public int shares { get ; set ; }
    public int keeps { get ; set ; }
    public object Img { get; internal set; }
  }
}