using RestWithASPNET.Data.VO;

namespace RestWithASPNET.Business
{
    public interface IloginBusiness
    {
        TokenVO ValidateCredentials(UserVO user);
        TokenVO ValidateCredentials(TokenVO token);
        bool RevokeToken(string userName);
    }
}
 