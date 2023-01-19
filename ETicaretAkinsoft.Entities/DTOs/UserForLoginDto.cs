using ETicaretAkinsoft.Core.Entities;

namespace ETicaretAkinsoft.Entities.DTOs
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
