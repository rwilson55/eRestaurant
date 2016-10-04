using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region AdditionalNamespaces
using System.Data.Entity;
using eRestaurantSystem.data.Entities;
#endregion

namespace eRestaurantSystem.DAL
{
    internal class eRestaurantContext:DbContext
    {
        public eRestaurantContext():base("eRestaurant")
        {
            
        }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillItem> BillItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationTable> ReservationTables { get; set; }
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Waiter> Waiters { get; set; }
    }
}
