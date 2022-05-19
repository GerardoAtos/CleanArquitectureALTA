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

    public class HEARTBEAT_CONFIRM_CTRLSEG
    {
        public string TRANID { get; set; }
        public string TRANDT { get; set; }
        public string WH_ID { get; set; }
        public string WCS_ID { get; set; }
        public HEARTBEAT_CONFIRM_SEG HEARTBEAT_SEG { get; set; }
    }

    public class HEARTBEAT_CONFIRM_SEG
    {
        public string TEXT { get; set; }
    }
}
