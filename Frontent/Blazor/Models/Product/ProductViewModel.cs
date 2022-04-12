namespace Blazor2.Models.Product
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandCompanyRepresentative { get; set; }
        public string BrandPhone { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Weight { get; set; }
        public bool WeightUnit { get; set; }
        public int Length { get; set; }

        public int TaxId { get; set; }
        public string TaxType { get; set; }
        public int Percentile { get; set; }


    }
}
