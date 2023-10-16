using AlmoCar.Models;

namespace AlmoCar.Repositories.Interfaces
{
    public interface IItemRepository
    {
        IEnumerable<Item> Itens { get; }
        IEnumerable<Item> ItensEmDestaque { get; }
        Item GetItemById(int itemId);
    }
}