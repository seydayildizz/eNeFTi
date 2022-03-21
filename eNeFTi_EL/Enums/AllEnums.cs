using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNeFTi_EL.Enums
{
    public class AllEnums
    {
    }
    public enum Genders : byte
    {
        Belirtilmemis,
        Bay,
        Bayan
    }
    public enum TheIdentityRoles : byte
    {
        Passive = 0,
        Admin = 1,
        Customer = 2,
        Supplier = 3,
        Editor = 4,
        Active = 5
    }

}
