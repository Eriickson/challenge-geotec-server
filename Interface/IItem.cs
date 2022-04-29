using challenge_geotec_server.Models;

namespace challenge_geotec_server.Models
{
    public interface IItem
    {
        List<Item> getItems();
        Item getItem(string search);
    }
}
