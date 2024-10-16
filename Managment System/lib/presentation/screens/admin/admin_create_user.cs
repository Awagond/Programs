using System.Diagnostics;

class AdminCreateUser : ViewModel
{
    public AdminCreateUser() : base(_name, _body, _action) { }
    private static string _name = "Admin menu - create user";
    private static string _body = "ID Admin - #0000\nLogin and password min 6 simbol.\nPassword requirements single character in the list [!@#$%^&*]\nsingle character in the range between [0-9]\nActions:\n0.Back\n1.Create User";


    private static void _errorInput()
    {
        Console.WriteLine("Wrong data input");
        Thread.Sleep(1000);
        Navigator.getInstance().UpdateCurrentNode("2.2");
    }
    private static void _action(String arg)
    {

        switch (arg)
        {
            case "0":
                Navigator.getInstance().UpdateCurrentNode("2");
                break;

            case "1":
                Console.WriteLine("Type user login");
                string login = Console.ReadLine();
                if (RegexHelper.rgxCheckOtherData(login))
                {

                }
                else
                {
                    _errorInput();
                    break;
                }

                Console.WriteLine("Type user password");
                string password = Console.ReadLine();
                if (RegexHelper.rgxCheckRPassword(password))
                {

                }
                else
                {
                    _errorInput();
                    break;
                }

                try
                {
                    Database.getInstance().Users.Add(new User(login, password, false));
                    Database.getInstance().SaveChanges();

                    Console.WriteLine("User " + login + " success created, return to main screen...");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something data broke. Try again...");
                    Thread.Sleep(1000);
                    Navigator.getInstance().UpdateCurrentNode("2.2");
                    break;
                }

                Thread.Sleep(3000);
                Navigator.getInstance().UpdateCurrentNode("2");
                break;


            default:
                Console.WriteLine("No actions.");
                Thread.Sleep(1000);
                Navigator.getInstance().UpdateCurrentNode("2.2");
                break;
        }
    }

}
