using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class Airport
    {
        Airplane plane;
        int width;
        int length;
        String PlaceName;
        /*class coord
        {
            int deg;
            //int min;
            //int sec;
            coord () = delete;
         
            coord(int d, int m=0, int s=0)
            {
                deg = d;
                //min = m;
                //sec = s;
            }
            
        }*/
        Airport(int w,int l)
        {
            width = w;
            length = l;
        }
        int distance(Airport a, Airport b)
        {
            int dist = sqrt( (a.w-b.w)(a.w-b.w) + (a.l-b.l)(a.l-b.l) );
            return dist;
        }
        
     
    }
}
