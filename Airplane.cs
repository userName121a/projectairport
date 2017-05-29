using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class Airplane
    {
        int places;
        int range;
        static int id = 0;
        int planeid;
        Airplane(int p, int r)
        {
            planeid = ++id;
            places  = p;
            range   = r;
        }
        Airplane(Airplane A)
        {
            this.places = A.places;
            this.range  = A.range;
            this.name   = A.name;
            this.id = ++id;
        }
        
    }
}
