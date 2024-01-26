using Newtonsoft.Json;

namespace ListExample.Models
{

    [JsonObject(MemberSerialization.OptIn)]
    public class List<Category>
    {
        [JsonProperty]
        public string? Name { get; set; }
        [JsonProperty]
        public List<Category> Categories { get; set; } = new List<Category>();
    }


}
