using Auctions.Models;

namespace Auctions.Data.Services
{
    public interface IListingsService
    {
        public IQueryable<Listing> GetAll();
    }
}
