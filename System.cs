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
		public static List<Airplane> Airplanes_load()
		{
			List<Airplane> Airplanes = new List<Airplane>();
			//wczytywanie samolotów
			return(Airplanes);//zwróć listę
		}

		public static List<Airplane> Airplanes_load_test()
		{
			List<Airplane> Airplanes = new List<Airplane>();
			Airplanes.Add (new Airplane (1, 20));
			Airplanes.Add (new Airplane (1, 40));
			return(Airplanes);//zwróć listę
		}

		public static List<Airport> Airports_load()
		{
			List<Airport> Airports = new List<Airport>();
			//wczytywanie lotnisk
			return(Airports);//zwróć listę
		}

		public static List<Client> Clients_load()
		{
			List<Client> Clients = new List<Client>();
			//wczytywanie klientów
			return(Clients);//zwróć listę
		}

		public static List<Flight> Flights_load()
		{
			List<Flight> Flights = new List<Flight>();
			//wczytywanie lotów
			return(Flights);//zwróć listę
		}


		//###################
		//FUNKCJE ZAPISYWANIA
		//###################

		public static void Airplanes_save(List<Airplane> Airplanes)
		{
			StreamWriter output = new StreamWriter ("Data/Airplanes.txt");
			Airplanes.ForEach(element =>
				{
					output.WriteLine(element.ToString()+"\n");//nie działa
				});
			output.Close ();
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
					Console.Out.WriteLine(element.ToString()+"\n");
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

		static int Main(string[] args)
		{
			Console.Out.WriteLine("Starting app\n");

			Airplanes = Airplanes_load_test();

			Airplanes_show (Airplanes);
			Airplanes_save (Airplanes);//nie działa, brak pojęcia czemu
			Console.Out.WriteLine("\nExiting app");
			return 0;
		}
    }
}