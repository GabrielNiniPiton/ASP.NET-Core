using Dev_Piton.Application.InputModels;
using Dev_Piton.Application.ViewModels;

namespace Dev_Piton.Application.Services.Interfaces
{
    public interface IUserService
    {
        UserViewModel GetUser(int id);

        int Create(CreateUserInputModel inputModel);
    }
}