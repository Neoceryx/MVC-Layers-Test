using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities; //References
using App.DAl; //References
namespace App.BLL
{
    public class UsersBLL
    {
        private UserRepository _userRepo;

        public UsersBLL()
        {
            _userRepo = new UserRepository();
        }

        public void Add(Users user)
        {
            _userRepo.Add(user);
        }

        public List<Users> GetAllUsersLinQ()
        {
            return _userRepo.GetAllLinQ();
        }

        public List<Users>GetAllUsersLambda()
        {
            return _userRepo.GetAllLambda();
        }
        

    }
}
