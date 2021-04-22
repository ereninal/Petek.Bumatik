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
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(Parent user);
    }
}
