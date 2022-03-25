using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public Tag()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }
    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public virtual ICollection<TreatFlavor> JoinEntities { get; set; }
  }
}