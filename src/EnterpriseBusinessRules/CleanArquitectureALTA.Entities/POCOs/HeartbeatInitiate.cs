using System;

namespace Alta.Entities.POCOs
{
    public class HeartbeatInitiate : Entity // HEARTBEAT_INITIATE - constraint en creation_time
    {
        public string TranId { get; set; } // (varchar(50), null)
        public string TranDT { get; set; } // (varchar(50), null)
        public string WHId { get; set; } // (varchar(50), null)
        public string WCSId { get; set; } // (varchar(50), null)
        public string Text { get; set; } // (varchar(MAX), null)
        
        public DateTime ResponseDatetime { get; set; } // (datetime, null)
        public string MessageReceived { get; set; } // (varchar(MAX), null)
        public DateTime CreationDatetime { get; set; } // (datetime, null) | CONSTRAINT: default value = getdate()

    }
}
