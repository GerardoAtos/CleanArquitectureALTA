using Alta.DTOs.DtoAbstraction;
using System.Text.Json.Serialization;

namespace Alta.DTOs
{
    public class MovementConfirmDTO : DtoBase
    {
        [JsonPropertyName("MOVEMENT_CONFIRM")]
        public MOVEMENTCONFIRM MOVEMENTCONFIRM { get; set; }
    }

    public class CTRLSEGMovementConfirm : CTRLSEGAbstractBase
    {
        [JsonPropertyName("MOVE_CONF_SEG")]
        public MOVECONFSEG MOVECONFSEG { get; set; }
    }

    public class MOVECONFSEG
    {
        [JsonPropertyName("LODNUM")]
        public string LODNUM { get; set; }

        [JsonPropertyName("DSTLOC")]
        public string DSTLOC { get; set; }
    }

    public class MOVEMENTCONFIRM
    {
        [JsonPropertyName("CTRL_SEG")]
        public CTRLSEGMovementConfirm CTRLSEG { get; set; }
    }
}
