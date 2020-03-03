using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoixResto.Models
{
    interface IDal
    {
        List<Resto> ObtientTousLesRestaurants();

    }
}
