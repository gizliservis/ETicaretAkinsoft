using ETicaretAkinsoft.Core.Entities.Concrete;
using ETicaretAkinsoft.Core.Utilities.Results;
using ETicaretAkinsoft.Core.Utilities.Security.JWT;
using ETicaretAkinsoft.Entities.DTOs;
using System;
using System.Text;

namespace ETicaretAkinsoft.Business.Abstract
{

    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
