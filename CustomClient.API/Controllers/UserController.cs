using CustomClient.Application.Commands;
using CustomClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomClient.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    [HttpPost]
    public ItemResult Create(CreateUserCommand createUser)
    {
        
        return ItemResult.SuccessResult();
    }
}