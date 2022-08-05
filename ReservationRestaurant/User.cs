using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationRestaurant
{
    internal class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }

        public int Password { get; set; }
        public DateTime Created { get; set; }

        public User(int userID, string username, int password)
        {

            this.UserID = userID;
            this.UserName = username;
            this.Password = password;
            this.Created = DateTime.Now;
        }
    }
}
