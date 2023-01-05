using FilmekGUI.Properties;
using Microsoft.Data.SqlClient;

namespace FilmekGUI
{
    internal class Core
    {
        private Core() { }

        public static void ErrorBox(string content) => MessageBox.Show(content, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        public static void InfoBox(string content) => MessageBox.Show(content, "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        public static string? SearchFilter;
        public static bool SearchByTitle;
        public static bool SearchByGenre;
        public static bool SearchByYear;

        private static readonly SqlConnection _connection = new(Resources.ConnString);
        
        public static void ManageSQL(bool start)
        {         
            if (start)
            {
                try
                {
                    _connection.Open();
                }
                catch (Exception error)
                {
                    ErrorBox($"Hiba történt az adatbázishoz való csatlakozáskor!\nDEBUG: {error}");
                    Environment.Exit(0);
                }
            }
            else _connection.Close();
        }

        public static SqlDataReader Query(string sql)
        {
            SqlDataReader? rdr = null;
            try
            {
                rdr = new SqlCommand(
                    cmdText: sql,
                    connection: _connection).ExecuteReader();
            }
            catch (Exception error)
            {
                ErrorBox($"Hiba történt az adatbázis művelet közben!\nDEBUG: {error}");
                Environment.Exit(0);
            }

            return rdr;
        }

        public static void InsertData(string sql)
        {
            try
            {
                ManageSQL(true);
                using SqlDataAdapter sda = new()
                {
                    InsertCommand = new(
                        cmdText: sql,
                        connection: _connection),
                };
                sda.InsertCommand.ExecuteNonQuery();
                ManageSQL(false);
            }
            catch (Exception error)
            {
                ErrorBox($"Hiba történt az adatbázis művelet közben!\nDEBUG: {error}");
                Environment.Exit(0);
            }         
        }

        public static void DeleteData(string sql)
        {
            try
            {
                ManageSQL(true);
                using SqlDataAdapter sda = new()
                {
                    DeleteCommand = new(
                        cmdText: sql,
                        connection: _connection),
                };
                sda.DeleteCommand.ExecuteNonQuery();
                ManageSQL(false);
            }
            catch (Exception error)
            {
                ErrorBox($"Hiba történt az adatbázis művelet közben!\nDEBUG: {error}");
                Environment.Exit(0);
            }
        }

        public static void UpdateData(string sql)
        {
            try
            {
                ManageSQL(true);
                using SqlDataAdapter sda = new()
                {
                    UpdateCommand = new(
                        cmdText: sql,
                        connection: _connection),
                };
                sda.UpdateCommand.ExecuteNonQuery();
                ManageSQL(false);
            }
            catch (Exception error)
            {
                ErrorBox($"Hiba történt az adatbázis művelet közben!\nDEBUG: {error}");
                Environment.Exit(0);
            }
        }
    }
}