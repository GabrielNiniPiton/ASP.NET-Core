using Dev_Piton.Application.ViewModels;
using MediatR;

namespace Dev_Piton.Application.Queries.GetAllSkills
{
    public class GetAllSkillsQuery : IRequest<List<SkillViewModel>>
    {
    }
}