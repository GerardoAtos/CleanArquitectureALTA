using System;

namespace Alta.Entities.POCOs
{
    public class User                               // Table: AltaNew_Users
    {
        public int Id { get; set; }                 // (int, not null)
        public string UserName { get; set; }        // (varchar(50), not null)
        public string Password { get; set; }        // (varchar(50), not null)
        public bool IsActive { get; set; }          // (int, not null)
        public DateTime CreationDate { get; set; }  // (datetime(50), not null)
        public string Comment { get; set; }         // (varchar(200), null)
    }
}
