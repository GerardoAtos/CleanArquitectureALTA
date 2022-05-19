using Alta.DTOs.DtoAbstraction;

namespace Alta.DTOs
{
    public class UserDTO : DtoBase
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
