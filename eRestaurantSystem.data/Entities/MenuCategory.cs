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
    public class MenuCategory
    {
        [Key]
        public int MenuCategoryID { get; set; }
        public string Description { get; set; }
    }
}
