using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PriorityOrder : Order
    {
        public TimePeriod DeliveryTimePeriod { get; set; }
        public DateTime DeliveryDate { get; set; }
        PriorityOrder(Address address, Cart cart, OrderStatus status, DateTime deliveryDate, TimePeriod deliveryTimePeriod) : 
        base(address, cart, status)
        {
            DeliveryDate = deliveryDate;
            DeliveryTimePeriod = deliveryTimePeriod;
        }

        public PriorityOrder() : base()
        {
            DeliveryDate = DateTime.Now;
            DeliveryTimePeriod = TimePeriod.NineToEleven;
        }
    }
}
