using System.Numerics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

class AdminCreateTask : ViewModel
{
    public AdminCreateTask() : base(_name, _body, _action) { }
    private static string _name = "Admin menu - create task";
    private static string _body = "ID Admin - #0000\n########\nInstruction: \nPrint the data one by one\n########\nActions:\n0.Back\n1.Create task";

    private static void _errorInput()
    {
        Console.WriteLine("Wrong data input");
        Thread.Sleep(1000);
        Navigator.getInstance().UpdateCurrentNode("2.1");
    }
    //Name\nDescription\nId-Project\nId-User\n
    private static void _action(String arg)
    {

        switch (arg)
        {
            case "0":
                Navigator.getInstance().UpdateCurrentNode("1");
                break;
            case "1":
                Console.WriteLine("Type task name");
                string name = Console.ReadLine();
                if (RegexHelper.rgxCheckOtherData(name))
                {

                }
                else
                {
                    _errorInput();
                    break;
                }

                Console.WriteLine("Type task description");
                string description = Console.ReadLine();
                if (RegexHelper.rgxCheckOtherData(description))
                {

                }
                else
                {
                    _errorInput();
                    break;
                }

                Console.WriteLine("Type id project");
                int idProject = int.Parse(Console.ReadLine());

                Console.WriteLine("Id-User");
                int idUser = int.Parse(Console.ReadLine());

                try
                {
                    User user = Database.getInstance().Users.FirstOrDefault(u => u.Id == idUser);
                    user.tasks = new List<Task>() { new Task(name, description, idProject, 0)};


                    Database.getInstance().Users.Update(user);
                    Database.getInstance().SaveChanges();

                    Console.WriteLine("Task" + name + " success created and appointed to User " + idUser + ", return to main screen...");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Something data broke. Try again...");
                    Thread.Sleep(10000);
                    Navigator.getInstance().UpdateCurrentNode("2.1");

                }

                Thread.Sleep(3000);
                Navigator.getInstance().UpdateCurrentNode("2");
                break;

            default:
                Console.WriteLine("No actions.");
                Thread.Sleep(1000);
                Navigator.getInstance().UpdateCurrentNode("2");
                break;
        }
    }

}
