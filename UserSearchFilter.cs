using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRL.LibertyRising.Messages
{
    public class UserSearchFilter
    {
        public int[] UserTypeIds { get; set; }

        public UserSearchFilter()
        {
            UserTypeIds = new int[]{ };
        }

    }
}
