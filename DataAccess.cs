using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace T_RexGame
{
    public static class DataAccess
    {
        // Metoda ce introduce utilizatorii in BD
        public static void InsertUser(string name, string surname, string email, string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TRexGameDB")))
            {
                List<User> users = new List<User> {
                    new User { Name = name, Surname = surname, Email = email, Username = username, UserPassword = password }
                };

                connection.Execute("dbo.insertUser @Name, @Surname, @Email, @Username, @UserPassword", users);
            }
        }

        // Metoda ce returneaza utilizatorii din BD, dupa un username anumit
        public static List<string> GetUsername(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TRexGameDB")))
            {
                List<string> output = connection.Query<string>($"dbo.getUsername @Username = {username}").ToList();
                return output;
            }
        }

        // Metoda ce returneaza utilizatorii din BD, dupa o parola anumita
        public static List<string> GetPassword(string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TRexGameDB")))
            {
                List<string> output = connection.Query<string>($"dbo.getPassword @Password = {password}").ToList();
                return output;
            }
        }

        // Metoda ce creeaza o vedere cu utilizatorul curent
        public static void CreateView(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TRexGameDB")))
            {
                connection.Execute($"CREATE OR ALTER VIEW currentUser (IdUser, UserName, UserPassword, Score, Hours, Minutes, Seconds, IdPerson, Name, Surname, Email) AS " +
                                        $"SELECT Persons.IdUser, UserName, UserPassword, Score, Hours, Minutes, Seconds, IdPerson, Name, Surname, Email FROM Users " +
                                            $"INNER JOIN Persons " +
                                                $"ON Users.IdUser = Persons.IdUser " +
                                        $"WHERE UserName = '{username}'");
            }
        }

        // Metoda ce preia datele din vedere
        public static List<User> GetDataFromView()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TRexGameDB")))
            {
                List<User> output = connection.Query<User>($"getDataFromView").ToList();
                return output;
            }
        }

        // Metoda ce actualizeaza datele utilizatorului curent
        public static void UpdateCurentUser(string userName, int score, string hours, string minutes, string seconds)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TRexGameDB")))
            {
                connection.Execute($"dbo.updateUser @UserName = '{userName}', @Score = {score}, @Hours = '{hours}', @Minutes = '{minutes}', @Seconds = '{seconds}'");
            }
        }
    }
}
