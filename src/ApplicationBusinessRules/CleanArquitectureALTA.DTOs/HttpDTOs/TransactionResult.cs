namespace Alta.DTOs.HttpDTOs
{
    public class TransactionResult
    {
        public bool OK { get; set; }
        public int CODE { get; set; }
        public string MESSAGE { get; set; }
        public dynamic DATA { get; set; }

    }
}   
