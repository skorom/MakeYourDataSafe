using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Firebase.Kecske
{
    public class Keystrokes
    {
        public int id { get; set; }
        public string key { get; set; }
    }

    public class GetKeystrokes : Keystrokes
    {
        public long Timestamp { get; set; }
    }

    public class SetKeystrokes : Keystrokes
    {
        [JsonProperty("Timestamp")]
        public ServerTimeStamp TimestampPlaceholder { get; } = new ServerTimeStamp();
    }
}