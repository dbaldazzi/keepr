
using Keepr.interfaces;

namespace Keepr.models
{

  public class Vaults : IVaults
  {
    public int id { get ; set ; }
    public string name { get ; set ; }
    public string description { get ; set ; }
    public string userId { get ; set ; }
  }
}