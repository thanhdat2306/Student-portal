﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortalAPI.Application.Features.Commands.Students.UpdateStudent
{
    public class UpdateStudentCommandRequest : IRequest<UpdateStudentCommandResponse>
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
