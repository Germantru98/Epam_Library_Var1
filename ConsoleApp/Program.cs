using BL;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ReaderBL bl = new ReaderBL();
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            string realpassword = "";
            try
            {
                if (!bl.IsLoginExist(login))
                {
                    throw new Exception("Введенного логина не существует");
                }
                else
                {
                    realpassword = bl.GetPasswordForLogin(login);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                var isLogin = true;
                while (isLogin)
                {
                    Console.Write("Введите логин еще раз: ");
                    login = Console.ReadLine();
                    if (bl.IsLoginExist(login))
                    {
                        isLogin = false;
                        break;
                    }
                }
            }
            finally
            {
                Console.Write("Ведите пароль: ");
                string tmppassword = Console.ReadLine();
                try
                {
                    if (realpassword == tmppassword)
                    {
                        Console.WriteLine("Вход выполнен успешно");
                    }
                    else
                    {
                        throw new Exception("Неверный пароль");
                    }
                }
                catch (Exception e)
                {
                    int attempt = 3;
                    Console.Write(e.Message + Environment.NewLine + "Введите пароль еще раз: ");
                    while (attempt > 0)
                    {
                        tmppassword = Console.ReadLine();
                        if (realpassword != tmppassword)
                        {
                            attempt--;
                            Console.WriteLine($"{e.Message}\nПопыток осталось:{attempt}");
                        }
                        else
                        {
                            Console.WriteLine("Вход выполнен успешно");
                            break;
                        }
                        if (attempt == 0)
                        {
                            Console.WriteLine("Завершение работы с приложением...");
                            break;
                        }
                    }
                }
            }
        }
    }
}