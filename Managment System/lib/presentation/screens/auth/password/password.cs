class Password : ViewModel
{
    public Password() : base(_name, _body, _action) { }
    private static string _name = "Password";
    private static string _body = "Enter you password: ";


    private static void _action(String arg)
    {

        switch (arg)
        {
            case "user":
            Navigator.getInstance().UpdateCurrentNode("3");
                break;

            case "admin":
            Navigator.getInstance().UpdateCurrentNode("2");
                break;

            default:
                Console.WriteLine("Something went wrong, reload...");
                Thread.Sleep(1000);
                Navigator.getInstance().UpdateCurrentNode("1");
                break;
        }
    }

}
