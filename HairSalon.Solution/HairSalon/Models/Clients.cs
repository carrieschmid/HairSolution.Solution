  
namespace HairSalon.Models
{
  public class Clients
  {
    public int ClientsId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }

    public int SylistsId { get; set; }

    public virtual Stylists Stylists { get; set; }
  }


}