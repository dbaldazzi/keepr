namespace Keepr.interfaces
{

  public interface IVaults
  {
    // int id { get; set; }
    int Id { get; set; }

    string name { get; set; }

    string description { get; set; }

    string userId { get; set; }
  }
}