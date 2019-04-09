using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Firebase.Kecske
{
    public class Pictures
    {
        public string id { get; set; }
        public string img { get; set; }
        public int type { get; set; } //3 - webcam | 4 - desktop
    }

    public class GetPictures : Pictures
    {
        public long Timestamp { get; set; }
    }

    public class SetPictures : Pictures
    {
        [JsonProperty("Timestamp")]
        public ServerTimeStamp TimestampPlaceholder { get; } = new ServerTimeStamp();
    }
}