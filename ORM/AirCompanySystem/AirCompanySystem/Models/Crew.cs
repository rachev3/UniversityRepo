using AirCompanySystem.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompanySystem.Models
{
    public class Crew : BaseModel
    {
        [MaxLength(100)]
        public string Name { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;
        public ICollection<Airplane> Airplanes { get; set; } = new List<Airplane>();
    }
}
