using Alta.DTOs.DtoAbstraction;
using System;
using System.Text.Json.Serialization;


namespace Alta.DTOs
{
    public class SavePrimeDataDTO : DtoBase
    {

        [JsonPropertyName("TRANID")]
        public string TranId { get; set; }

        [JsonPropertyName("DATA")]
        public string Data { get; set; }

        [JsonPropertyName("ENDPOINT")]
        public string Endpoint { get; set; }

        [JsonPropertyName("APPLICATION")]
        public string Application { get; set; }

        [JsonPropertyName("DATE")]
        public DateTime Date { get; set; }

    }
}
