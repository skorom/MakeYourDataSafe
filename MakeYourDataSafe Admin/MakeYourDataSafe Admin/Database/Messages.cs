using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Firebase.Kecske
{
    public class Messages
    {
        public string id { get; set; }
        public string message { get; set; }
    }

    public class GetMessages : Messages
    {
        public long Timestamp { get; set; }
    }

    public class SetMessages : Messages
    {
        [JsonProperty("Timestamp")]
        public ServerTimeStamp TimestampPlaceholder { get; } = new ServerTimeStamp();
    }
}