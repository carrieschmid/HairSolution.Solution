  
namespace HairSalon.Models
{
  public class Clients
  {
    public int ClientsId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int StylistsId { get; set; }

    public virtual Stylists Stylists { get; set; }
  }


}