namespace HotelListings.API.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        //Connect it to Hotel
        public virtual IList<Hotel> Hotels { get; set; }
    }
}