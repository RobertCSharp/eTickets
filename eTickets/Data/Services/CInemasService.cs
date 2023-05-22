using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
	public class CInemasService : EntityBaseRepository<Cinema>, ICinemasService
	{
		public CInemasService(AppDbContext context) : base(context)
		{

		}
	}
}
