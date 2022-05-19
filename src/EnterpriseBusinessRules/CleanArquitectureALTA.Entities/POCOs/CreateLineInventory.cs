using Alta.Entities.POCOs.Abstractions;

namespace Alta.Entities.POCOs
{
    public class CreateLineInventory : Entity
    {
        public CREATELINEINVENTORYINIFD CREATE_LINE_INVENTORY_IN_IFD { get; set; }
    }
    public class CREATELINEINVENTORYINIFD
    {
        public CTRLSEG CTRL_SEG { get; set; }
        public CREATELINEINVENTORYSEG CREATE_LINE_INVENTORY_SEG { get; set; }
    }

    public class CTRLSEG : AbstractCTRLSEG
    {
        //this is only using the base abstract class
    }

    public class CREATELINEINVENTORYSEG
    {
        public string WKONUM { get; set; }
        public string WKOREV { get; set; }
        public string PRDLIN { get; set; }
        public string UOMCOD { get; set; }
        public int PRTNUM { get; set; }
        public string INVSTS { get; set; }
        public int UNTQTY { get; set; }
        public string LOTNUM { get; set; }
        public string DSTLOC { get; set; }
        public string LODNUM { get; set; }
        public string ASSET_TYP { get; set; }
        public string INV_ATTR_DTE1 { get; set; }
        public string INV_ATTR_DTE2 { get; set; }
    }
}
 