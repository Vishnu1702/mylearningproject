using System.Collections.Generic;
using System.Linq;

namespace MAADISWEETS.Models
{
    public class SweetRepository : ISweetRepository
    {
        private readonly SweetAppDbContext _sweetAppDbContext;

        public SweetRepository(SweetAppDbContext sweetAppDbContext)
        {
            _sweetAppDbContext = sweetAppDbContext;
        }

        public IEnumerable<Sweets> getAllSweet()
        {
            return _sweetAppDbContext.Sweets;
        }

        public Sweets getSweetById(int sweetId)
        {
            return _sweetAppDbContext.Sweets.FirstOrDefault(p => p.SweetId == sweetId);
        }
    }
}