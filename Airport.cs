using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class Airport
    {
        private String name;
        private int width;
        public int height;
        private int id;
        
        private static int counter = 0;
        public Airport(int width,int height,String name)
        {
            this.name = name;
            this.width = width;
            this.height = height;
            id = ++counter;
        }
        public Airport(Airport airport)
        {
            name = airport.name;
            width = airport.width;
            height = airport.height;
            id = ++counter;
        }

        public int getWidth() { return width; }
        public int getHeigth() { return height; }
        public String getName() { return name; }

        public override String ToString()
        {
            return name + " " + id + "\nwidth " + width + "\nheight " + height + "\n";
        }



    }
}
