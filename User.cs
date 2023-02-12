
namespace T_RexGame
{
    // Clasa User ce detine informatia fiecarui utilizator
    public class User
    {
        // Incapsularea variabilelor,
        // pentru a le proteja de folosinta necorespunzatoare
        public string IdUser { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public int Score { get; set; }
        public string Hours { get; set; }
        public string Minutes { get; set; }
        public string Seconds { get; set; }
        public string IdPerson { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string FullInfo {
            get {
                return $"{IdUser} {Username} {UserPassword} {Score} {Hours} {Minutes} {Seconds} {IdPerson} {Name} {Surname} {Email}";
            }
        }
    }
}
