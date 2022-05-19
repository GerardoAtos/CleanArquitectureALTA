using Alta.DTOs.DtoAbstraction;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Alta.DTOs
{
    public class HeartBeatInitiateDTO : DtoBase
    {
        [JsonPropertyName("HEARTBEAT_INITIATE")]
        public HEARTBEATINITIATE HEARTBEATINITIATE { get; set; }
    }

    public class HEARTBEATINITIATE
    {
        [JsonPropertyName("CTRL_SEG")]
        public CTRLSEG CTRLSEG { get; set; }

        [JsonPropertyName("HEARTBEAT_SEG")]
        public HEARTBEATSEG HEARTBEATSEG { get; set; }
    }

    public class HEARTBEATSEG
    {
        [JsonPropertyName("TEXT")]
        public string TEXT { get; set; }
    }

}
