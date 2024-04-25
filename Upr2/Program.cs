using Upr1.Model;
using Upr1.Others;
using Upr1.View;
using Upr1.ViewModel;
using Upr2.Others;

namespace Upr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var user = new User
                {
                    Name = "Asen",
                    Password = "password",
                    Role = UserRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);

                view.Display();

                view.DisplayError();
            }
            catch (Exception ex)
            {
                var log = new ActionOnError(Delegates.Log);
                var logF = new ActionOnError(Delegates.LogFile);
                log(ex.Message);
                logF(ex.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case");
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
