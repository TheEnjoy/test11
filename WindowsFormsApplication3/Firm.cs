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

    class Firm
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

        public Firm()
        {
            NameOfFirm = "";
            Properties = new Firms_Properties();
        }
        public Firm(string nameofFirm, Firms_Properties proper)
        {
            NameOfFirm = nameOfFirm;
            Properties = proper;
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


    }

    #endregion конец класса Firm
}
