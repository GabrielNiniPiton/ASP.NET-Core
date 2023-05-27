using Dev_Piton.Application.ViewModels;
using MediatR;

namespace Dev_Piton.Application.Queries.GetUser
{
    public class GetUserQuery : IRequest<UserViewModel>
    {
        public GetUserQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}