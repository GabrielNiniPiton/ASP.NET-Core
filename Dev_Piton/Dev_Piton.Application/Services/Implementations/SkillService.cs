﻿using Dev_Piton.Application.Services.Interfaces;
using Dev_Piton.Application.ViewModels;
using Dev_Piton.Infrastructure.Persistence;

namespace Dev_Piton.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly DevFreelaDbContext _dbContext;

        public SkillService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<SkillViewModel> GetAll()
        {
            var skills = _dbContext.Skills;

            var skillsViewModel = skills.Select(s => new SkillViewModel(s.Id, s.Description)).ToList();

            return skillsViewModel;
        }
    }
}