using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Core.Utilities.Results;
using Petek.BUmatik.Core.Utilities.Security.Hashing;
using Petek.BUmatik.Core.Utilities.Security.JWT;
using Petek.BUmatik.Entities.Concrete;
using Petek.BUmatik.Shared.Constants;
using Petek.BUmatik.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<Parent> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new Parent
            {
                Email = userForRegisterDto.Email,
                FullName = userForRegisterDto.Fullname,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                IsDeleted = false
            };
            _userService.Add(user);
            return new SuccessDataResult<Parent>(user, Messages.UserRegistered);
        }

        public IDataResult<Parent> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<Parent>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<Parent>(Messages.PasswordError);
            }

            return new SuccessDataResult<Parent>(userToCheck, Messages.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(Parent user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }

        public IDataResult<AdminUser> AdminUserRegister(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new AdminUser
            {
                Email = userForRegisterDto.Email,
                FullName = userForRegisterDto.Fullname,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                IsDeleted = false
            };
            _userService.AdminUserAdd(user);
            return new SuccessDataResult<AdminUser>(user, Messages.UserRegistered);
        }

        public IDataResult<AdminUser> AdminUserLogin(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.AdminUserGetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<AdminUser>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<AdminUser>(Messages.PasswordError);
            }

            return new SuccessDataResult<AdminUser>(userToCheck, Messages.SuccessfulLogin);
        }
    }
}
