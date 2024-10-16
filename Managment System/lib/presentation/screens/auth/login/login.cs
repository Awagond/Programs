class Login : ViewModel
{
    public Login() : base(_name, _body, _action) { }
    private static string _name = "Login";
    private static string _body = "Enter you login: ";
    private static void _action(String arg)
    {
        switch (arg)
        {
            case "user":
            Navigator.getInstance().UpdateCurrentNode("1.2");
                break;

            case "admin":
            Navigator.getInstance().UpdateCurrentNode("1.2");
                break;

            default:
                Console.WriteLine("Something went wrong, reload...");
                Thread.Sleep(1000);
                Navigator.getInstance().UpdateCurrentNode("1");
                break;
        }
    }

}
