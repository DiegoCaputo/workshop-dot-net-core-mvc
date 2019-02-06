using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMvc.Models.Enums
{
    public enum SallesStatus : int
    {
        Pending = 0,
        Billed = 1,
        Canceled = 2
    }
}
