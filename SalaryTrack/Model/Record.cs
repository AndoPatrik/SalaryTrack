using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryTrack.Model
{
    public class Record
    {
        private int _recordID;
        private int _userID;        
        private int _salarayPerHour;
        private int _taxPercent;        
        private int _workedHours;
        private string _workplace;
        private DateTime _workedDate;

        public Record(int recordID, int userID, int salarayPerHour, int taxPercent, int workedHours, string workplace, DateTime workedDate)
        {
            RecordID = recordID;
            UserID = userID;
            SalarayPerHour = salarayPerHour;
            TaxPercent = taxPercent;
            WorkedHours = workedHours;
            Workplace = workplace;
            WorkedDate = workedDate;
        }

        public int RecordID { get => _recordID; set => _recordID = value; }
        public int UserID { get => _userID; set => _userID = value; }
        public int SalarayPerHour { get => _salarayPerHour; set => _salarayPerHour = value; }
        public int TaxPercent { get => _taxPercent; set => _taxPercent = value; }
        public int WorkedHours { get => _workedHours; set => _workedHours = value; }
        public string Workplace { get => _workplace; set => _workplace = value; }
        public DateTime WorkedDate { get => _workedDate; set => _workedDate = value; }
    }
}
