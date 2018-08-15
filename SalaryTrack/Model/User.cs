using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryTrack.Model
{
    public class User
    {
        private int _userID;
        private int _salaryPerHour;
        private int _taxPercent;
        private string _pW;
        private string _firstName;
        private string _lastName;        
        private string _email;        
        private string _workplace;

        public User(int userID, int salaryPerHour, int taxPercent, string pW, string firstName, string lastName, string email, string workplace)
        {
            UserID = userID;
            SalaryPerHour = salaryPerHour;
            TaxPercent = taxPercent;
            PW = pW;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Workplace = workplace;
        }

        public int UserID { get => _userID; set => _userID = value; }
        public int SalaryPerHour { get => _salaryPerHour; set => _salaryPerHour = value; }
        public int TaxPercent { get => _taxPercent; set => _taxPercent = value; }
        public string PW { get => _pW; set => _pW = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Workplace { get => _workplace; set => _workplace = value; }
    }
}
