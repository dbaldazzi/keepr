using keepr.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Keepr.Models
{
  public class VaultKeeps : IVaultKeeps
  {
    public int vaultId { get; set; }
    public int keepId { get; set; }

    public int Id { get; set; }

    public string UserId { get; set; }
  }
}
