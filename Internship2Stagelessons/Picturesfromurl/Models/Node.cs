using Newtonsoft.Json;

namespace Picturesfromurl.Models
{
    public class Node
    {
        [JsonProperty("PicBytes")]
        public byte[] Bytes { get; set; }
    }
}