using System.Text.Json.Serialization;

namespace RestWithASPNET.Data.VO
{
    public class PersonVO
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }
        [JsonPropertyName("sex")]

        public string Gender { get; set; }
    }
}
