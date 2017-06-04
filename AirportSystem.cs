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
		List<Airplane> Airplanes = new List<Airplane>();
		List<Airport> Airports = new List<Airport>();
		List<Client> Clients = new List<Client>();
		List<Flight> Flights = new List<Flight>();

		public List<Airplane> Airplanes_load()
		{
			List<Airplane> Airplanes = new List<Airplane>();
			//wczytywanie samolotów
			return(Airplanes);//zwróć listę
		}

		public List<Airport> Airports_load()
		{
			List<Airport> Airports = new List<Airport>();
			//wczytywanie lotnisk
			return(Airports);//zwróć listę
		}

		public List<Client> Clients_load()
		{
			List<Client> Clients = new List<Client>();
			//wczytywanie klientów
			return(Clients);//zwróć listę
		}

		public List<Flight> Flights_load()
		{
			List<Flight> Flights = new List<Flight>();
			//wczytywanie lotów
			return(Flights);//zwróć listę
		}

		public void Airplanes_save()
		{
			//zapisywanie samolotów
		}

		public void Airports_save()
		{
			//zapisywanie lotnisk
		}

		public void Clients_save()
		{
			//zapisywanie klientów
		}

		public void Flights_save()
		{
			//zapisywanie lotów
		}

		static int Main(string[] args)
		{
			
			return 0;
		}
    }
}
