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
    public class Recipe
    {
        [Key]
        public int RecipeID { get; set; }
        public string Instructions { get; set; }
        public int PrepTime { get; set; }
        public int ItemID { get; set; }
    }
}
