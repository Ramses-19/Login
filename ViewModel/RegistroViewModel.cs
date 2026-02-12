using Login.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ViewModel
{
    public class RegistroViewModel
    {
        private readonly IUserRepository _userRepository;

        public RegistroViewModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Login(User userLogin)
        {

        }
    }
}
