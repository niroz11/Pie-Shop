using System;
using System.Collections.Generic;

namespace Pie.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();

        Pie GetPieById(int pieId);

    }
}
