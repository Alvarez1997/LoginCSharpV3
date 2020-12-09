using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CapaSoporte.Cache;

namespace Domain
{
    public class UserModel
    {
        UserData userData = new UserData();
        public bool LoginUser(string user, string pass)
        {
            return userData.Login(user, pass);
        }

        #region Seguridad y Permisos
        public void CualquierMetodo() //remplazar con lo que necesite hacer el programa
        {
            //seguridad y permisos
            if (UserLoginCache.Position == CargosBD.Administrator)
            {
                //cualquier cosa que solo el admin pueda hacer
                //como modificar la base de datos
            }

            if (UserLoginCache.Position == CargosBD.Receptionist || UserLoginCache.Position == CargosBD.Accounting)
            {
                //limitaciones de ususarios standar
            }
        }
        #endregion
    }
}