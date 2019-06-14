using System.Collections.Generic;

namespace MAADISWEETS.Models
{
    public interface ISweetRepository
    {
        IEnumerable<Sweets> getAllSweet();

        Sweets getSweetById(int sweetId);
    }

}