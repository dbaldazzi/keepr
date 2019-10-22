using keepr.Interfaces;

namespace Keepr.Models
{
  public class VaultKeeps : IVaultKeeps
  {
    public string VaultId { get; set; }
    public string KeepId { get; set; }

    public int Id { get; set; }
    public string UserId { get; set; }
  }
}
