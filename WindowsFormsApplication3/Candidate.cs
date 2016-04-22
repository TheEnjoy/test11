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


    class Candidate
    {
        string nameOfCandidate;
        public Candidate_Properties properties;

        public Candidate()
        {
            NameOfCandidate = "";
            Properties = new Candidate_Properties();
        }

        public Candidate(string nameOfCandidate, Candidate_Properties proper)
        {
            NameOfCandidate = nameOfCandidate;
            Properties = proper;
        }

        public string NameOfCandidate
        {
            get { return NameOfCandidate; }
            set { value = NameOfCandidate; }
        }
        public Candidate_Properties Properties
        {
            get { return Properties; }
            set { value = Properties; }
        }
    }


}
