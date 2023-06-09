﻿using Dev_Piton.Application.ViewModels;
using Dev_Piton.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Dev_Piton.Application.Queries.GetProjectById
{
    public class GetProjectByIdQueryHandler : IRequestHandler<GetProjectByIdQuery, ProjectDetailsViewModel>
    {
        private readonly DevFreelaDbContext _dbContext;

        public GetProjectByIdQueryHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProjectDetailsViewModel> Handle(GetProjectByIdQuery request, CancellationToken cancellationToken)
        {
            var project = await _dbContext.Projects.Include(p => p.Client)
                                                   .Include(p => p.Freelancer)
                                                   .SingleOrDefaultAsync(p => p.Id == request.Id);

            if (project == null) return null;

            var projectDetailsViewModel = new ProjectDetailsViewModel(project.Id,
                                                                      project.Title,
                                                                      project.Description,
                                                                      project.TotalCost,
                                                                      project.StartedAt,
                                                                      project.FinishAt,
                                                                      project.Client.FullName,
                                                                      project.Freelancer.FullName);

            return projectDetailsViewModel;
        }
    }
}