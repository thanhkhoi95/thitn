using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THITN
{
    class CauHoi
    {
        public string mach;
        public string noidung;
        public string cauA;
        public string cauB;
        public string cauC;
        public string cauD;
        public string dapan;

        public CauHoi(string mach, string noidung, string cauA, string cauB, string cauC, string cauD)
        {
            this.mach = mach;
            this.noidung = noidung;
            this.cauA = cauA;
            this.cauB = cauB;
            this.cauC = cauC;
            this.cauD = cauD;
            dapan = "X";
        }
    }
}
