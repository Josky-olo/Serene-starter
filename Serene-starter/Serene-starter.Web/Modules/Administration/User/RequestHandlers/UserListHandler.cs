using MyRequest = Serene_starter.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<Serene_starter.Administration.UserRow>;
using MyRow = Serene_starter.Administration.UserRow;

namespace Serene_starter.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}