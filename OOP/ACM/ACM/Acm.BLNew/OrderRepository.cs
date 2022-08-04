using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acm.BLNew
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }
        public bool Save(Order order)
        {
            var success = true;
            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
