using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class Track
    {
        private  Airport A;
        private  Airport B;
        public double length;
        private TimeSpan timelength;
        private int costPLN;

        public Track(ref Airport airport1,ref  Airport airport2)
        {
            A = airport1;
            B = airport2;
            length = Math.Sqrt( (airport1.getHeigth() - airport2.getHeigth()) * (airport1.getHeigth() - airport2.getHeigth()) + (airport1.getWidth() - airport2.getWidth()) *(airport1.getWidth() - airport2.getWidth()) );
            costPLN = (int)length * 10;
            long a = (long)(length*60);
            timelength = TimeSpan.FromMinutes(a);
        }
        public double getLength() { return Math.Sqrt( (A.getHeigth() - B.getHeigth()) * (A.getHeigth() - B.getHeigth()) + (A.getWidth() - B.getWidth()) * (A.getWidth() - B.getWidth()) ); }
        public TimeSpan getTimeLength() { return timelength; }
        public int getCostPLN() { return costPLN; }
    }
}

