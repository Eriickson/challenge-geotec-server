using challenge_geotec_server.Models;

namespace challenge_geotec_server.Repository
{
    public class ItemRepository : IItem
    {
        List<Item> items = new List<Item>
        {
            new Item{ Id=1, Description= "Description 1", ImageUrl= "url image 1", Name= "Name 1", Price= 25000.00f, Talle= "XL" },
            new Item{ Id=2, Description= "Description 2", ImageUrl= "url image 2", Name= "Name 2", Price= 50000.00f, Talle= "XL" },
            new Item{ Id=3, Description= "Description 3", ImageUrl= "url image 3", Name= "Name 3", Price= 75000.00f, Talle= "XL" },
        };

        public Item getItem(string search)
        {
            return items[0];
        }

        public List<Item> getItems()
        {
            return items;
        }
    }
}
