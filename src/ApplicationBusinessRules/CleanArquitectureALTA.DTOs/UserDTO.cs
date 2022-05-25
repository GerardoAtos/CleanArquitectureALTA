using Alta.DTOs.DtoAbstraction;

namespace Alta.DTOs
{
    public class UserDTO : DtoBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
