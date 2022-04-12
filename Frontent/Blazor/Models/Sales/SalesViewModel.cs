namespace Blazor2.Models.Sales
{
    public class SalesViewModel
    {
        public int Id { get; set; }
        public int Piece { get; set; }
        public DateTime Deliverydate { get; set; }
        public DateTime DateOfTransction { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerFirstAndLastName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int BrandsId { get; set; }
        public string BrandsName { get; set; }

        public int CategoryId { get; set; }
        public string CateogryName { get; set; }
        public decimal Price { get; set; }




        public int TaxtId { get; set; }
        public string TaxType { get; set; }
        public int Percentile { get; set; }

    }
}
