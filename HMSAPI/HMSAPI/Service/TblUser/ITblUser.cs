using HMSAPI.Model.TblUser;

namespace HMSAPI.Service.TblUser
{
    public interface ITblUser
    {
        bool validateCredential(string email,string password);
        TblUserModel? validateCredentialWithData(string email,string password);
    }
}
