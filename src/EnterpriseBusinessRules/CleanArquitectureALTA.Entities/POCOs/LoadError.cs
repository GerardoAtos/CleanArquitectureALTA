using Alta.Entities.POCOs.Abstractions;

namespace Alta.Entities.POCOs
{
    public class LoadError : RequestConfirm
    {
        public LOAD_ERROR LOAD_ERROR { get; set; }
    }

    public partial class LOAD_ERROR
    {
        public LOAD_ERROR_CTRLSEG CTRL_SEG { get; set; }
    }

    public partial class LOAD_ERROR_CTRLSEG : AbstractCTRLSEG
    {
        public LOAD_ERROR_SEG LOAD_ERR_SEG { get; set; }

    }


    public partial class LOAD_ERROR_SEG
    {
        public string LODNUM { get; set; }
        public string ERROR_CODE { get; set; }
    }
}
