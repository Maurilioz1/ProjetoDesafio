using Sistema.DBModel;
using System.Linq;

namespace Sistema.Models
{
    public class UsuarioDAL
    {
        public static bool VerificaEmail(string email)
        {
            using (UserDBEntities dc = new UserDBEntities())
            {
                var existeEmail = (from u in dc.Users
                                   where u.Email == email
                                   select u).FirstOrDefault();
                if (existeEmail != null)
                    return true;
                else
                    return false;
            }
        }
    }
}