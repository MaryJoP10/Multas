using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl_Multas.Interfaces
{
    interface ISancionEconomica
    {
        ulong Calcular_sancion(ulong val_sal_min);
    }
}
