/*
 * 1.- Validar si el usuario existente o si debe registrar y generar un sistema de registro o login
 * 2.- el programa debe ser capaz de darle la bienvenida a un usuario esistente si en efecto existe
 * el programa debe repetirse hasta que se registre las 10 persona
*/

using System;
namespace ReservationRestaurant
{
    class Program
    {

        static void Main(string[] args)
        {
        
            UserService users = new UserService();
            ReservationService reservation = new ReservationService();

            Dictionary<int, string> options = new Dictionary<int, string>();
            options.Add(1, "Register User");
            options.Add(2, "Search users for name");
            options.Add(3, "List users");
            options.Add(4, "Search user");
            options.Add(5, "All Reservations");
            options.Add(6, "Create reservation");

            foreach (var item in options)
            {
                Console.WriteLine($"option {item.Key} -> {item.Value}");
            }

            while (true)
            {
           
                SelectedOption(options,users, reservation);
            }          
   
        }

        static void SelectedOption(Dictionary<int, string> options, UserService users,ReservationService reservation) {
   
            try
            {
            
                int userType;
                Console.WriteLine("Selected one option....");
                userType = Convert.ToInt32(Console.ReadLine());


                if (options.ContainsKey(userType))
                {
                    Random rnd = new Random();
                    int num = rnd.Next();
                    Console.WriteLine(options[userType]);
                    switch (userType)
                    {
                        case 1:                     
                            Console.WriteLine($"Hello, you are register user, please enter your exact user name");
                        
                            string userToSearc = Console.ReadLine();
                                users.CreateUser(num, userToSearc, 123);
                            break;
                        case 2:
                            string name = Console.ReadLine();
                            foreach (var item in users.GetUsersByName(name))
                                Console.WriteLine("Nombre : "+item.UserName);
                            break;
                        case 3:
                            Console.WriteLine(@"UserID      Nombre        Password");
                            foreach (var item in users.GetUser()) { 
                                Console.WriteLine($"{item.UserID}    {item.UserName}         {item.Password}");
                            }                   
                            break;
                        case 4:
                            Console.WriteLine("write id...");
                            int id = Convert.ToInt32(Console.ReadLine());              
                            foreach (var item in users.GetUsersID(id))
                                Console.WriteLine("Name user " + item.UserName);
                            break;
                        case 5:
                            Console.WriteLine("id                 Type          Level          Date");
                            foreach (var item in reservation.GetReservation())
                            {
                                Console.WriteLine($"{item.ReservationID}         {item.ReservationName}         {item.ReservationLevel}        {item.DateReservation}");
                            }
                            break;
                        case 6:
                            Console.WriteLine("write name reservation.......");
                            string nameReservation = Console.ReadLine();
                            Console.WriteLine("write level reservation.......");
                            int levelReservation = Convert.ToInt32(Console.ReadLine());
                            reservation.CreateReservation(num,nameReservation, levelReservation,DateTime.Now);
                            break;
                    }
                    
                }

                else
                {
                    Console.WriteLine("Not valid options. Enter option existens");
                }

            }
            catch (Exception e) {
                Console.WriteLine("operation failed....");

            }
        }

    }

}
