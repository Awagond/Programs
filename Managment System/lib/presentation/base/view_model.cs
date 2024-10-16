using System.Reflection;
using System.Text;

class ViewModel(string _name, string _body, Action<string> _action)
{
    private int _countSeporator = 40;
    private char _seporator = '-';
    private LoginModel auth = LoginModel.getInstance();
    private string name;
    private string body;
    private Action<string> action;

    public string buildHeader(string name)
    {
        int center = (_countSeporator - name.Length) / 2;
        StringBuilder sb = new StringBuilder("", _countSeporator);
        sb.Append(Seporate(_seporator, center));
        sb.Append(name);
        sb.Append(Seporate(_seporator, center));

        return sb.ToString();
    }

    public string buildFooter()
    {
        StringBuilder sb = new StringBuilder("", _countSeporator);
        sb.Append(Seporate(_seporator, _countSeporator));
        return sb.ToString();
    }

    public void printView()
    {
        Console.Clear();
        Console.WriteLine("Debug - Current node " + Navigator.getInstance().CurrentNode());
        Console.WriteLine(buildHeader(_name));
        Console.WriteLine(_body);
        Console.WriteLine(buildFooter());
        _action(Console.ReadLine());
        Thread.Sleep(1000); // Костыль для обратной связи с пользователем
    }

    private static string Seporate(char ch, int count)
    {
        return new string(ch, count);
    }

}

/***

---------Login----------
Enter you login:
---------Login----------


--------Password--------
Enter you password:
--------Password--------


--------Main Menu--------
Admin - 0000
-------------------------
1.Create task
2.Create user
3.Logout
--------Main Menu--------


--------Main Menu--------
User - 0123
-------------------------
1.Check list task's
2.Select task
3.Logout
--------Main Menu--------


--------Task list--------
User - 0123
-------------------------
1. Back
2. Select Task
#########################
Task id - Task name 1 
Task id - Task name 2
Task id - Task name 3 
Task id - Task name 4 
--------Task list--------

--------Select Task------
User - 0123
-------------------------
1.Enter id
--------Main Menu--------


--------Task-------------
User - 0123
-------------------------
Id - 00001
Name - Sb
Description - Suka Bluad
Status - to do
-------------------------
Select action
1. Back
2. Change status
--------Task list--------


--------Task-------------
User - 0123
-------------------------
Id - 00001
Name - Sb
Description - Suka Bluad
Status - to do
-------------------------
Select action
1. Back
2. "to do"
3. "in progress"
4. "done"
--------Task list--------
**/
