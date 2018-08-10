using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDevelopingSam.Models
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            if(user.IsAdmin)
            {
                return true;
            }
            if(MadeBy == user)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsAdmin { get; set; }

    }
}
