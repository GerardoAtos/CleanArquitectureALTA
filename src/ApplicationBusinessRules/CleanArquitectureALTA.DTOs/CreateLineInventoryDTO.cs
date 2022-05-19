using Alta.DTOs.DtoAbstraction;
using System.Text.Json.Serialization;

namespace Alta.DTOs
{
    public class CreateLineInventoryDTO : DtoBase
    {
        [JsonPropertyName("CREATE_LINE_INVENTORY_IN_IFD")]
        public CREATELINEINVENTORYINIFD CREATE_LINE_INVENTORY_IN_IFD { get; set; }

    }
    public class CREATELINEINVENTORYINIFD
    {
        [JsonPropertyName("CTRL_SEG")]
        public CTRLSEG CTRL_SEG { get; set; }

        [JsonPropertyName("CREATE_LINE_INVENTORY_SEG")]
        public CREATELINEINVENTORYSEG CREATE_LINE_INVENTORY_SEG { get; set; }
    }

    public class CTRLSEG : CTRLSEGAbstractBase
    {
        //this is only using the base abstract class
    }

    public class CREATELINEINVENTORYSEG
    {
        [JsonPropertyName("WKONUM")]
        public string WKONUM { get; set; }

        [JsonPropertyName("WKOREV")]
        public string WKOREV { get; set; }

        [JsonPropertyName("PRDLIN")]
        public string PRDLIN { get; set; }

        [JsonPropertyName("UOMCOD")]
        public string UOMCOD { get; set; }

        [JsonPropertyName("PRTNUM")]
        public int PRTNUM { get; set; }

        [JsonPropertyName("INVSTS")]
        public string INVSTS { get; set; }

        [JsonPropertyName("UNTQTY")]
        public int UNTQTY { get; set; }

        [JsonPropertyName("LOTNUM")]
        public string LOTNUM { get; set; }

        [JsonPropertyName("DSTLOC")]
        public string DSTLOC { get; set; }

        [JsonPropertyName("LODNUM")]
        public string LODNUM { get; set; }

        [JsonPropertyName("ASSET_TYP")]
        public string ASSET_TYP { get; set; }

        [JsonPropertyName("INV_ATTR_DTE1")]
        public string INV_ATTR_DTE1 { get; set; }

        [JsonPropertyName("INV_ATTR_DTE2")]
        public string INV_ATTR_DTE2 { get; set; }
    }
    
}

