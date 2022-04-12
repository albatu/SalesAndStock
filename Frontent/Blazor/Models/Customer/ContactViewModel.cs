namespace Blazor2.Models.Customer
{
    public class ContactViewModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string FirstNameAndLastName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressDetails { get; set; }
        public string PostCode { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string Phone { get; set; }
    }
}
