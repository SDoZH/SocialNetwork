using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;

namespace SocialNetwork
{
    internal class Program
    {
        public static UserService userService = new UserService();


        static void Main(string[] args)
        {
            Console.WriteLine("Добро поаловать в нашу соцсеть");
            while (true)
            {
                Console.WriteLine("Длярегистрации пользователя введите имя пользователя:");
                string firstName = Console.ReadLine();
                Console.Write("Фамилия:");
                string lastName = Console.ReadLine();
                Console.Write("Пароль:");
                string password = Console.ReadLine();
                Console.Write("Email:");
                string email = Console.ReadLine();

                UserRegistrationData userRegistrationData = new UserRegistrationData()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Password = password,
                    Email = email
                };

                userService.Registrer(userRegistrationData);

                try
                {
                    userService.Registrer(userRegistrationData);
                    Console.WriteLine("Пользователь зарегистрирован успешно");
                }

                catch (ArgumentNullException)
                {
                    Console.WriteLine("Введите корректрные значения!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Произошла ошибка при регистрации.");
                }

                Console.ReadLine();

            }
        }
    }
}