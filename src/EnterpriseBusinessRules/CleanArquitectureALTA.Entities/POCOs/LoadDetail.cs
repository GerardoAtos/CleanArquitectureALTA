namespace Alta.Entities.POCOs
{
    public class LoadDetail // JSON File "LOAD_ERROR", tipos inferidos del documento y las demas tablas.
    {
        public string LODNum_DEFAULT = "00";
        
        public int Id { get; set; } // (int, not null)
        public string TranId { get; set; } // (varchar(50), null)
        public string TranDT { get; set; } // (varchar(50), null)
        public string WHId { get; set; } // (varchar(50), null)
        public string WCSId { get; set; } // (varchar(50), null)


        public string PRTNum { get; set; }
        public string PRTClientId { get; set; }
        public string UNTCAS { get; set; }
        public string InventoryStatus { get; set; }
        public string UnitQuantity { get; set; }
        public string ORGCOD { get; set; }
        public string REVLVL { get; set; }
        public string LOTNum { get; set; }
        public string SupLotNum { get; set; }
        public string DSTLoc { get; set; }
        public string LODNum { get; set; }
        public string SubNum { get; set; }
        public string DTLNum { get; set; }
        public string FTPCOD { get; set; }
        public string UNTPAK { get; set; }
        public long FIFDate { get; set; }
        public long MANDate { get; set; }
        public string AgePFLName { get; set; }
        public string CatchQuantity { get; set; }
        public string ExpirationDate { get; set; }
        public string LODTag{ get; set; }
        public string SubTag { get; set; }
        public int PHYFlag { get; set; }
        public string SupNum { get; set; }
        public int CNSGFlag { get; set; }
        public string AssetType { get; set; }
        public string SubAssetType { get; set; }
        public string MandateFMT { get; set; }
        public string MandateFMTValue { get; set; }
        public string ExpirationDateFMT { get; set; }
        public string ExpirationDateFMTValue { get; set; }
        public string INV_ATTR_STR1 { get; set; }
        public string INV_ATTR_STR2 { get; set; }
        public string INV_ATTR_STR3 { get; set; }
        public string INV_ATTR_STR4 { get; set; }
        public string INV_ATTR_STR5 { get; set; }
        public string INV_ATTR_STR6 { get; set; }
        public string INV_ATTR_STR7 { get; set; }
        public string INV_ATTR_STR8 { get; set; }
        public string INV_ATTR_STR9 { get; set; }
        public string INV_ATTR_STR10 { get; set; }
        public string INV_ATTR_STR11 { get; set; }
        public string INV_ATTR_STR12 { get; set; }
        public string INV_ATTR_STR13 { get; set; }
        public string INV_ATTR_STR14 { get; set; }
        public string INV_ATTR_STR15 { get; set; }
        public string INV_ATTR_STR16 { get; set; }
        public string INV_ATTR_STR17 { get; set; }
        public string INV_ATTR_STR18 { get; set; }
        public string INV_ATTR_INT1 { get; set; }
        public string INV_ATTR_INT2 { get; set; }
        public string INV_ATTR_INT3 { get; set; }
        public string INV_ATTR_INT4 { get; set; }
        public string INV_ATTR_INT5 { get; set; }
        public int INV_ATTR_FLT1 { get; set; }
        public int INV_ATTR_FLT2 { get; set; }
        public int INV_ATTR_FLT3 { get; set; }
        public long INV_ATTR_DTE1 { get; set; }
        public long INV_ATTR_DTE2 { get; set; }
        public string CSTMSConsignmentId { get; set; }
        public int CSTMSBondFlag { get; set; }
        public int DTYStampFlag { get; set; }
        public int LOAD_ATTR1_FLG { get; set; }
        public int LOAD_ATTR2_FLG { get; set; }
        public int LOAD_ATTR3_FLG { get; set; }
        public int LOAD_ATTR4_FLG { get; set; }
        public int LOAD_ATTR5_FLG { get; set; }
    }
}
