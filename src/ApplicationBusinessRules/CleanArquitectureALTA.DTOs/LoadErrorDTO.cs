using System.Text.Json.Serialization;
using Alta.DTOs.DtoAbstraction;

namespace Alta.DTOs
{
    public class LoadErrorDTO : RequestConfirmDTO
    {
        [JsonPropertyName("LOAD_ERROR")]
        public LOAD_ERROR LoadError { get; set; }
    }

    public partial class LOAD_ERROR
    {
        [JsonPropertyName("CTRL_SEG")]
        public LOAD_ERROR_CTRLSEG CtrlSeg { get; set; }

    }

    public partial class LOAD_ERROR_CTRLSEG : CTRLSEGAbstractBase
    {
        
        [JsonPropertyName("LOAD_ERR_SEG")]
        public LOAD_ERROR_SEG LoadErrorSeg { get; set; }

    }


    public partial class LOAD_ERROR_SEG
    {
        [JsonPropertyName("LODNUM")]
        public string LODNUM { get; set; }

        [JsonPropertyName("ERROR_CODE")]
        public string ERROR_CODE { get; set; }

    }
}