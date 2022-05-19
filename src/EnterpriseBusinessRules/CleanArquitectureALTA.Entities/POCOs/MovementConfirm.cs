using Alta.Entities.POCOs.Abstractions;

namespace Alta.Entities.POCOs
{
    public class MovementConfirm : Entity
    {
        public MOVEMENTCONFIRM MOVEMENT_CONFIRM { get; set; }
    }
    public class MOVEMENTCONFIRM
    {
        public CTRLSEGMovementConfirm CTRL_SEG { get; set; }
    }

    public class CTRLSEGMovementConfirm : AbstractCTRLSEG
    {
        public MOVECONFSEG MOVE_CONF_SEG { get; set; }
    }

    public class MOVECONFSEG
    {
        public string LODNUM { get; set; }
        public string DSTLOC { get; set; }
    }
}
