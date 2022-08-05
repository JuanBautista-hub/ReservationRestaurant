using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationRestaurant
{
    internal class UserService
    {
        private List<User> users = new List<User>();

        public void CreateUser(int id, string name, int pass) {
   
            foreach (User user in GetUsersID(id)) {
                if (user.UserID == id)
                {
                    throw new InvalidOperationException("User exist ");
                }
            }

            this.users.Add(new User(id,name,pass));
                Console.WriteLine("usuario registrado");
        }

        public List<User> GetUser() {
           
            return this.users.ToList();
        }

        public List<User> GetUsersByName(string name)
        {
        
            return this.users.Where(item => item.UserName == name ).ToList();
        }

        public List<User> GetUsersID(int id)
        {
            return this.users.Where(item => item.UserID == id).ToList();
        }
    }
}
