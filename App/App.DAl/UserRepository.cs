using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities; // references.

namespace App.DAl
{
    public class UserRepository
    {
        private SalesDbContext _context;

        public UserRepository()
        {
            _context = new SalesDbContext();
        }


        public void Add(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public List<Users>GetAllLinQ()
        {
            return (from e in _context.Users
                    select e).ToList();
        }

        public List<Users>GetAllLambda()
        {
            return _context.Users.ToList();
        }


    }
}
