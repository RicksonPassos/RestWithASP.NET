using RestWithASPNET.Data.VO;

namespace RestWithASPNET.Model
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
        User ValidateCredentials(string userNAme);
        bool RevokeToken(string userName);
        User RefreshUserInfo(User user);


    }
}
