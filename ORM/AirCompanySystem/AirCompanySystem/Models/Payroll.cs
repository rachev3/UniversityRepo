using AirCompanySystem.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompanySystem.Models
{
    public class Payroll : BaseModel
    {
        public decimal Total { get; set; }

        // One payroll belongs to one passenger
        public int PassengerId { get; set; }
        public virtual Passenger Passenger { get; set; } = null!;

        // One payroll belongs to one ticket
        public int TicketId { get; set; }
        public virtual Ticket Ticket { get; set; } = null!;
    }
}
