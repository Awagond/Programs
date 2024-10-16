class AdminMenu : ViewModel
{
    public AdminMenu() : base(_name, _body, _action) { }
    private static string _name = "Admin menu";
    private static string _body = "ID Admin - #0000\n########\nActions:\n0.Logout\n1.Create task\n2.Create user";


    private static void _action(String arg)
    {

        switch (arg)
        {
            case "0":
            Navigator.getInstance().UpdateCurrentNode("1");
                break;

            case "1":
            Navigator.getInstance().UpdateCurrentNode("2.1");
                break;

            case "2":
            Navigator.getInstance().UpdateCurrentNode("2.2");
                break;

            default:
                Console.WriteLine("No actions.");
                Thread.Sleep(1000);
                Navigator.getInstance().UpdateCurrentNode("2");
                break;
        }
    }

}
