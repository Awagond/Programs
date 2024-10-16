class Start : ViewModel {
    private static string _name = "Managment system";
    private static string _body = "Version 1.0 | Press any key";

    public Start() : base(_name, _body, _action) {}

    private static void _action(String arg)
    {
        Navigator.getInstance().UpdateCurrentNode("1.1");
    }
}