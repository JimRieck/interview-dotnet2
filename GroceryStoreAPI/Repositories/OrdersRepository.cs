using GroceryStoreAPI.Interfaces;
using GroceryStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroceryStoreAPI.Repositories
{
    public class OrdersRepository : BaseRepository, IOrdersRepository
    {
        IItemsRepository itemRepository;

        public OrdersRepository(IItemsRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        public List<Orders> GetAll()
        {
            List<Orders> returnedOrders = new List<Orders>();

            dynamic orders = ReadDataFromFile("orders");

            foreach (dynamic order in orders)
            {
                Orders newOrder = new Orders { id = order.id, customerId = order.customerId, items = new List<Items>() };

                List<Items> newItems = itemRepository.GetAll(order.ToString());

                newOrder.items.AddRange(newItems);

                returnedOrders.Add(newOrder);
                
            }

            
            return returnedOrders;
            
        }

       

        public Orders GetById(int id)
        {
            return this.GetAll().FirstOrDefault(p => p.id == id);
        }

        public Orders Save(Orders order)
        {
            throw new NotImplementedException();
        }
    }
}
