﻿using CustomClient.Domain.Models;
using MediatR;

namespace CustomClient.Application.Commands;

public class CreateUserCommand : IRequest<User>
{
    public string Username { get; set; }
    
    public string Password { get; set; }

    public string FirstName { get; set; }
    
    public string LastName { get; set; }
}