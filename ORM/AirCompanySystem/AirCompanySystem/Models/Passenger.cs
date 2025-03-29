using AirCompanySystem.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompanySystem.Models
{
    public class Passenger : BaseModel
    {
        [MaxLength(150)]
        public string Name { get; set; }

        // One passenger can have many tickets
        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
