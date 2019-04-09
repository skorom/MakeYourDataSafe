using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Firebase.Kecske
{
    public class Commands
    {
        public string id { get; set; }
        public int cmd { get; set; }
    }

    public class GetCommands : Commands
    {
        public long Timestamp { get; set; }
    }

    public class SetCommands : Commands
    {
        [JsonProperty("Timestamp")]
        public ServerTimeStamp TimestampPlaceholder { get; } = new ServerTimeStamp();
    }
}