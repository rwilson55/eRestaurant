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
    public class Bill
    {
        [Key]
        public int BillID { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime? OrderPlaced { get; set; }
        public DateTime? OrderReady { get; set; }
        public DateTime? OrderServed { get; set; }
        public DateTime? OrderPaid { get; set; }
        public int NumberInParty { get; set; }
        public bool PaidStatus { get; set; }
        [ForeignKey("WaiterID")]
        public int WaiterID { get; set; }
        [ForeignKey("TableID")]
        public int TableID { get; set; }
        [ForeignKey("ReservationID")]
        public int ReservationID { get; set; }
        public string Comment { get; set; }
    }
}
