using System.Text.Json.Serialization;

namespace RestWithASPNET.Data.VO
{
    public class BookVO
    {
        [JsonPropertyName("code_of_book")]
        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public DateTime LaunchDate { get; set; }
    }
}
