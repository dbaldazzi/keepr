namespace keepr.Interfaces
{
  public interface IVaultKeeps
  {
    int Id { get; set; }
    string UserId { get; set; }
    string VaultId { get; set; }
    string KeepId { get; set; }
  }
}