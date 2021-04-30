using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.Core.Utilities.Security.JWT;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<Parent> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<Parent> Login(UserForLoginDto userForLoginDto);
        IDataResult<AdminUser> AdminUserRegister(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<AdminUser> AdminUserLogin(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IResult AdminUserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(Parent user);
        IDataResult<AccessToken> AdminUserCreateAccessToken(AdminUser user);
    }
}
