using Alta.Entities.POCOs.Abstractions;

namespace Alta.Entities.POCOs
{
    public class HeartBeatConfirm : Entity
    {
        public HEARTBEAT_CONFIRM HEARTBEAT_CONFIRM { get; set; }
    }

    public class HEARTBEAT_CONFIRM
    {
        public HEARTBEAT_CONFIRM_CTRLSEG CTRL_SEG { get; set; }
    }

    public class HEARTBEAT_CONFIRM_CTRLSEG : AbstractCTRLSEG
    {
        public HEARTBEAT_CONFIRM_SEG HEARTBEAT_SEG { get; set; }
    }

    public class HEARTBEAT_CONFIRM_SEG
    {
        public string TEXT { get; set; }
    }
}
