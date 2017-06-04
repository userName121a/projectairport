using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class Airplane
    {
        static private int counter = 0;
        private int places;
        private int range;
        private int id;

        public Airplane(int places, int range)
        {
            this.places = places;
            this.range = range;
            id = ++counter;

        }
        public Airplane(Airplane airplane)
        {
            places = airplane.places;
            range = airplane.range;
            id = ++counter;
        }
        public int getPlaces() { return places; }
        public int getRange() { return range; }
        public int getId() { return id; }
        public static int getPlanesCount() { return counter; }
        
        override public String ToString()
        {
            String propert = "Plane nr  "+ id + "\nplaces " + places + "\nrange " + range + "\n";
            return propert;
        }
        

    }
}
