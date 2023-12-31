﻿using Blog.Domain.Entities.User;
using Blog.Domain.Entities.User.Dto;
using Blog.Domain.Entities.User.Vo;
using System.Security.Claims;

namespace Blog.Application.Services.Account;


public sealed class AuthenticationService
{
    public Task Login(LoginDto requestDto)
    {
        throw new NotImplementedException();
    }

    public Task Logout(UserId issuer, UserId userId)
    {
        throw new NotImplementedException();
    }

    public UserEntity Register(RegisterDto requestDto)
    {
        throw new NotImplementedException();
    }

    public UserEntity AddUserClaim(UserId userId, Claim claim)
    {
        throw new NotImplementedException();
    }

    public Task GenerateCookieAuthentication(string username)
    {
        throw new NotImplementedException();
    }
}