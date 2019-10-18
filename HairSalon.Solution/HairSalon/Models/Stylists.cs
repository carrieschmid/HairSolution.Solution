using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylists
    {
        public Stylists()
        {
            this.Clients = new HashSet<Clients>();
        }

        public int StylistsId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public virtual ICollection<Clients> Clients { get; set; }
    }
}