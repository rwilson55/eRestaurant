using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace eRestaurantSystem.data.Entities
{
    public class SpecialEvent
    {
        [Key]
        public char EventCode { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
