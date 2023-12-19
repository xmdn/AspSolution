using CustomClient.Application.Commands;
using CustomClient.Domain.Models;
using CustomClient.Infastructure.Context;
using MediatR;

namespace CustomClient.Application.Handlers;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, User>
{
    private readonly AppDbContext _dbContext;

    public CreateUserHandler(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {

    }
}