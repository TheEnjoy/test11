using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{

    [Flags]
    public enum Firms_Properties
    {
        HardWork = 1,
        Strong = 1,
        Smog = -1,
        Small = -1
    }

    public class Firm
    #region начало Firm
    {
        //public Firms_Properties Properties;
        //string fam = "";

        //public string Fam
        //{
        //    set { if (fam == "") fam = value; }
        //    get { return (fam); }
        //}

        //public Firm() { }
        //public Firm(string fam)
        //{
        //    this.fam = fam;
        //}

        private string nameOfFirm;
        public Firms_Properties properties;
        private Candidate_Properties preference;

        public Firm()
        {
            NameOfFirm = "";
            Properties = new Firms_Properties();
            Preference = new Candidate_Properties();
        }

        public Firm(string nameofFirm)
        {
            NameOfFirm = nameofFirm;
            Properties = new Firms_Properties();
            Preference = new Candidate_Properties();
        }
        public Firm(string nameofFirm, Firms_Properties proper , Candidate_Properties pref)
        {
            NameOfFirm = nameofFirm;
            Properties = proper;
            Preference = pref;
        }
        public string NameOfFirm
            {
            get {return nameOfFirm; }
            set {nameOfFirm=value; }       
            }
        public Firms_Properties Properties
            {
            get { return properties; }
            set { properties = value; }
        }
        public Candidate_Properties Preference
        {
            get { return preference; }
            set { value = preference; }
        }

    }

    #endregion конец класса Firm
}
