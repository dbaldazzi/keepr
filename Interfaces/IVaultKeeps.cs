namespace keepr.Interfaces 
{
    public interface IVaultKeeps
    {
        int vaultId { get; set; }
        int keepId { get; set;  }
        int Id { get; set;  }

        string UserId { get; set;  }
  }
}