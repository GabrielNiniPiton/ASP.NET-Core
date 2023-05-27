﻿using Dev_Piton.Core.Entities;
using Dev_Piton.Infrastructure.Persistence;
using MediatR;

namespace Dev_Piton.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly DevFreelaDbContext _dbContext;

        public CreateUserCommandHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.FullName, request.Email, request.BirthDate);

            await _dbContext.Users.AddAsync(user);

            await _dbContext.SaveChangesAsync();

            return user.Id;
        }
    }
}