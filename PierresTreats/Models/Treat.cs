using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }
    public int TreatId { get; set; }
    public string TreatName { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<RecipeTag> JoinEntities { get; set; }
  }
}