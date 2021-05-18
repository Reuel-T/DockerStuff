namespace HotelApi
{
    public class Hotel
    {
        public int HotelID { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public string City { get; set; }
        public int Rating { get; set; }
        public string ImageUrl { get; set; }
        public Hotel(){}

        public Hotel(string name, string website, string city, int rating, string url)
        {
            this.Name= name;
            this.Website= website;        
            this.City= city;
            this.Rating = rating;
            this.ImageUrl = url;
        }
    }
}