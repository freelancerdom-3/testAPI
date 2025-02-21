using HMSAPI.Model.TblUser;

namespace HMSAPI.Service.TblUser
{
    public class TblUser : ITblUser
    {
        public bool validateCredential(string email, string password)
        {
            if (email == "test@gmail.com" && password == "Abc@123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public TblUserModel? validateCredentialWithData(string email, string password)
        {
            if (email == "test@gmail.com" && password == "Abc@123")
            {
                return new TblUserModel() {
                    UserId=1,
                    Email="test@gmail.com",
                    FullName="Naitik Gondaliya"
                };
            }
            else
            {
                return null;
            }
        }
    }
}
