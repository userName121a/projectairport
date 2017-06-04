using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class Client
    {
		List<Ticket> Tickets = new List<Ticket>();

		public Client()
		{
			
		}
    }
    class IndividualClient : Client
    {
		public IndividualClient()
		{

		}
    }
    class CompanyClient : Client
    {
		public CompanyClient()
		{

		}
    }
}
