using ExProposto.Entities.Enums;

namespace ExProposto.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }


        public double Total()
        {
            //int totalItems = 0;
            //foreach (OrderItem item in Items)
            //{
            //    totalItems += item.Quantity;
            //}
            //return totalItems;

            foreach (Order item in Items)
            {
                
            }
        }
    }
}
