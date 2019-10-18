using Keepr.interfaces;

namespace Keepr.Models
{

  public class Keeprs : IKeeps
  {
    public int id { get ; set ; }
    public string name { get ; set ; }
    public string description { get ; set ; }
    public string userid { get ; set ; }
    public int views { get ; set ; }
    public int shares { get ; set ; }
    public int keeps { get ; set ; }
  }
}