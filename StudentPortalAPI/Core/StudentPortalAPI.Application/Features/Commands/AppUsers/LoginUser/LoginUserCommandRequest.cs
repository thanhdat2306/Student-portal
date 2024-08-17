﻿using MediatR;

namespace StudentPortalAPI.Application.Features.Commands.AppUsers.LoginUser
{
    public class LoginUserCommandRequest : IRequest<LoginUserCommandResponse>
    {
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
