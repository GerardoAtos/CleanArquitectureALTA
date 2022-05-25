using Alta.Entities.POCOs.Abstractions;

namespace Alta.Entities.POCOs
{
    public class HeartBeatInitiate : Entity
    {
        public HEARTBEATINITIATE HEARTBEAT_INITIATE { get; set; }
    }

    public class HEARTBEATINITIATE
    {
        public AbstractCTRLSEG CTRL_SEG { get; set; }
        public HEARTBEATSEG HEARTBEAT_SEG { get; set; }
    }



    public class HEARTBEATSEG
    {
        public string TEXT { get; set; }
    }
}
