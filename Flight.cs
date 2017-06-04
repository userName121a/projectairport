using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class Flight
    {
        Track track;
        DateTime begintime;
        DateTime endtime;
        Airplane airplane;
        Flight(ref Track track, DateTime begin,ref Airplane airplane)
        {
            this.track = track;
            begintime = begin;
            endtime = begin + this.track.getTimeLength();
            this.airplane = airplane;
        }
    }
}
