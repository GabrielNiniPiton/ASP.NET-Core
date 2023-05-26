using Dev_Piton.Application.ViewModels;

namespace Dev_Piton.Application.Services.Interfaces
{
    public interface ISkillService
    {
        List<SkillViewModel> GetAll();
    }
}