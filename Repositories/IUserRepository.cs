using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Repositories
{
    public interface IUserRepository
    {
        List<User> ObtenerUsuarios();

        bool Login(string username, string password);

        void AgregarUsuarios(string username, string password);
    }

    public class User
    {
    }
}
