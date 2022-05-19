using System.Text.Json.Serialization;
using Alta.DTOs.DtoAbstraction;

namespace Alta.DTOs
{
    public class HeartBeatConfirmDTO : DtoBase
    {
        [JsonPropertyName("HEARTBEAT_CONFIRM")]
        public HEARTBEAT_CONFIRM HeartBeatConfirm { get; set; }
    }

    public class HEARTBEAT_CONFIRM
    {
        [JsonPropertyName("CTRL_SEG")] public HEARTBEAT_CONFIRM_CTRLSEG CtrlSeg { get; set; }
    }

    public class HEARTBEAT_CONFIRM_CTRLSEG
    {
        [JsonPropertyName("TRANID")] public string Tranid { get; set; }

        [JsonPropertyName("TRANDT")] public string Trandt { get; set; }

        [JsonPropertyName("WH_ID")] public string WhId { get; set; }

        [JsonPropertyName("WCS_ID")] public string WcsId { get; set; }


        [JsonPropertyName("HEARTBEAT_SEG")] public HEARTBEAT_CONFIRM_SEG HeartBeatConfirmSeg { get; set; }
    }

    public class HEARTBEAT_CONFIRM_SEG
    {
        [JsonPropertyName("TEXT")] public string TEXT { get; set; }
    }
}