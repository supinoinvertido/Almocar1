namespace AlmoCar.Models
{
    public class CarrinhoItem
    {
            public int CarrinhoItemId { get; set; }
            public Item Item { get; set; }
            public int Quantidade { get; set; }
            public string CarrinhoId { get; set; }
        }
    }
