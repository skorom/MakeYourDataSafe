using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Firebase.Kecske
{
    public class Computers
    {
        public string ip_address { get; set; }
        public string pc_name { get; set; }
        public bool has_webcam { get; set; }
        public string city { get; set; }
    }

    public class GetComputers : Computers
    {
        public long Timestamp { get; set; }
    }

    public class SetComputers : Computers
    {
        [JsonProperty("Timestamp")]
        public ServerTimeStamp TimestampPlaceholder { get; } = new ServerTimeStamp();
    }

    public class ServerTimeStamp
    {
        [JsonProperty(".sv")]
        public string TimestampPlaceholder { get; } = "timestamp";
    }
}