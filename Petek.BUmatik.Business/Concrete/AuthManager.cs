using Petek.BUmatik.Business.Abstract;
using Petek.BUmatik.Business.BusinessAspects.Autofac;
using Petek.BUmatik.Core.Aspects.Autofac.Caching;
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
        private IParentService _userService;
        private IAdminUserService _adminUserService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IParentService userService, ITokenHelper tokenHelper, IAdminUserService adminUserService)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _adminUserService = adminUserService;
        }
        [CacheRemoveAspect("IStudentService.Get")]//herşey interface üzerinden oluyor. Tümü silmek içini tırnak içine Get yazdığımızda tüm get isteklerini siler -Eren
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
        public IResult AdminUserExists(string email)
        {
            if (_adminUserService.AdminUserGetByMail(email) != null)
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
            _adminUserService.AdminUserAdd(user);
            return new SuccessDataResult<AdminUser>(user, Messages.UserRegistered);
        }

        public IDataResult<AdminUser> AdminUserLogin(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _adminUserService.AdminUserGetByMail(userForLoginDto.Email);
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

        public IDataResult<AccessToken> AdminUserCreateAccessToken(AdminUser user)
        {
            var accessToken = _tokenHelper.AdminCreateToken(user);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }
    }
}
