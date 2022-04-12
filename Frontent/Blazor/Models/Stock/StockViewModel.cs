namespace Blazor2.Models.Stock
{
    public class StockViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Piece { get; set; }
        public DateTime StockDate { get; set; }
        public decimal Price { get; set; }
        public int BrandsId { get; set; }
        public string BrandsName { get; set; }

        public int CategoryId { get; set; }
        public string CateogryName { get; set; }
    }
}
