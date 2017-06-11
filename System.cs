using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace projekt2
{
    class AirportSystem
    {
        static List<Airplane> Airplanes = new List<Airplane>();
        static List<Airport> Airports = new List<Airport>();
        static List<Client> Clients = new List<Client>();
        static List<Flight> Flights = new List<Flight>();

        //###################
        //FUNKCJE WCZYTYWANIA
        //###################
        private static List<string[]> readfile(string filename )
        {
            string[] file = File.ReadAllLines(filename);
            string[] Stringnumbers;
            List<string[]> datas = new List<string[]>();
            foreach (string stringline in file)
            {
                Stringnumbers = stringline.Split(' ');
                
                datas.Add(Stringnumbers);
            }
            return (datas);

        }
        public static List<Airplane> Airplanes_load()
        {
           
            List<Airplane> Airplanes = new List<Airplane>();
            List<string[]> data = readfile("data/Airplanes.txt");

            foreach(string[] line in data)
            {
                Airplanes.Add(new Airplane(int.Parse(line[0]), int.Parse(line[1])));
            }
            //wczytywanie samolotów
            return (Airplanes);//zwróć listę
        }

        public static List<Airplane> Airplanes_load_test()
        {
            List<Airplane> Airplanes = new List<Airplane>();
            Airplanes.Add(new Airplane(1, 20));
            Airplanes.Add(new Airplane(1, 40));
            return (Airplanes);//zwróć listę
        }

        public static List<Airport> Airports_load()
        {
            List<Airport> Airports = new List<Airport>();
            //wczytywanie lotnisk
            List<string[]> data = readfile("data/Airplanes.txt");
            foreach(string[] line in data)
            {
                Airports.Add(new Airport(int.Parse(line[0]), int.Parse(line[1]), line[2]));
            }
            return (Airports);//zwróć listę
        }

        public static List<Client> Clients_load()
        {
            List<Client> Clients = new List<Client>();
            //wczytywanie klientów
            List<string[]> data = readfile("data/Airplanes.txt");
            foreach (string[] line in data)
            {
                //Clients.Add(new) TODO brak klientów
            }
            return (Clients);//zwróć listę
        }

        public static List<Flight> Flights_load()
        {
            List<Flight> Flights = new List<Flight>();
            //wczytywanie lotów  TODO
            return (Flights);//zwróć listę
        }


        //###################
        //FUNKCJE ZAPISYWANIA
        //###################

        public static void Airplanes_save(List<Airplane> Airplanes)
        {
            StreamWriter output = new StreamWriter("Data/Airplanes.txt");
            Airplanes.ForEach(element =>
            {
                output.WriteLine(element.ToString() + "\n");//nie działa
            });
            output.Close();
        }

        public static void Airports_save()
        {
            //zapisywanie lotnisk
        }

        public static void Clients_save()
        {
            //zapisywanie klientów
        }

        public static void Flights_save()
        {
            //zapisywanie lotów
        }

        //####################
        //FUNKCJE WYŚWIETLANIA
        //####################

        public static void Airplanes_show(List<Airplane> Airplanes)
        {
            Airplanes.ForEach(element =>
            {
                Console.Out.WriteLine(element.ToString() + "\n");
            });
        }

        public static void Airports_show()
        {

        }

        public static void Clients_show()
        {

        }

        public static void Flights_show()
        {

        }

       /* static int Main(string[] args)
        {
            Console.Out.WriteLine("Starting app\n");

            //Airplanes = Airplanes_load_test();

           // Airplanes_show(Airplanes);
           // Airplanes_save(Airplanes);//nie działa, brak pojęcia czemu
            Console.Out.WriteLine("\nExiting app");
            return 0;
        }*/
    }
}
