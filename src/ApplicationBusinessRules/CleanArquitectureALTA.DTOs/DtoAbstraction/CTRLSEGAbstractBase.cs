using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Alta.DTOs.DtoAbstraction
{
    public abstract class CTRLSEGAbstractBase
    {
        [JsonPropertyName("TRANID")]
        public long TRANID { get; set; }

        [JsonPropertyName("TRANDT")]
        public long TRANDT { get; set; }

        [JsonPropertyName("WCS_ID")]
        public string WCS_ID { get; set; }

        [JsonPropertyName("WH_ID")]
        public string WH_ID { get; set; }

    }
}
