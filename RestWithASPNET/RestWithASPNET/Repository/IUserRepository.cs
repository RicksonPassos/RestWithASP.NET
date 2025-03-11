using RestWithASPNET.Data.VO;
using RestWithASPNET.Model;

namespace RestWithASPNET.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
        User ValidateCredentials(string userNAme);
        bool RevokeToken(string userName);
        User RefreshUserInfo(User user);


    }
}
