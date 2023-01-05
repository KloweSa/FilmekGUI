using Microsoft.Data.SqlClient;

namespace FilmekGUI
{
    internal class Auth
    {
        private Auth() { }

        private static bool _authorized = false;
        public static bool Authorized { get => _authorized; }

        public static bool Authorization(string username, string password)
        {
            Core.ManageSQL(true);
            using SqlDataReader rdr = Core.Query($"SELECT userId FROM users WHERE userName = '{username}' AND userPassword = '{password}';");
            if (rdr.Read())
            {
                Core.InfoBox("Sikeres azonosítás!\nMostantól elérhető a program összes funkciója.");
                _authorized = true;
                Core.ManageSQL(false);
                return true;
            }
            else
            {
                Core.ErrorBox("Hibás azonosítási adatok!");
                Core.ManageSQL(false);
                return false;
            }          
        }
    }
}