namespace Keepr
{

  public interface IVaults
  {
    int id { get; set; }

    string name { get; set; }

    string description { get; set; }

    string userId { get; set; }
  }
}