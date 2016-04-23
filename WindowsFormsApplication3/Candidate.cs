using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    [Flags]
    public enum Candidate_Properties
    {
        HardWork = 1,
        Strong = 1,
        Smog = -1,
        Small = -1
    }


    public class Candidate
    {
        string nameOfCandidate;
        private Candidate_Properties properties;
        private Firms_Properties preference;
        public Candidate()
        {
            NameOfCandidate = "";
            Properties = new Candidate_Properties();
            Preference = new Firms_Properties();
        }

        public Candidate(string nameOfCandidate)
        {
            NameOfCandidate = nameOfCandidate;
            Properties = new Candidate_Properties();
            Preference = new Firms_Properties();
        }

        public Candidate(string nameOfCandidate, Candidate_Properties proper, Firms_Properties pref)
        {
            NameOfCandidate = nameOfCandidate;
            Properties = proper;
            Preference = pref;
        }

        public string NameOfCandidate
        {
            get { return nameOfCandidate; }
            set { value = nameOfCandidate; }
        }
        public Candidate_Properties Properties
        {
            get { return properties; }
            set { value = properties; }
        }
        public Firms_Properties Preference
        {
            get { return preference; }
            set { value = preference; }
        }
    }


}
